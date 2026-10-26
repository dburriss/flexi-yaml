#load "load-library.fsx"
open Flexi.Yaml
open Flexi.Yaml.YamlExtensions

let text = """name: web
replicas: many
ports:
  - 80
  - 443
released: 2026-10-14
"""

// ParseWithPositions is Parse plus a side table: the source span of every node, keyed by
// RFC 6901 JSON Pointer ("" is the root, "/ports/0" the first port).
let value, spans = YamlValue.ParseWithPositions text

let show (pointer: string) =
    let s = spans.[pointer]
    printfn "%-12s line %d col %d -> line %d col %d (offset %d..%d)"
        pointer s.Start.Line s.Start.Column s.End.Line s.End.Column s.Start.Offset s.End.Offset

printfn "-- spans --"
show "/name"
show "/ports/0"
show "/ports/1"

// Typical use: validate a value, then point at the exact spot in the source.
printfn "-- validation error with a location --"
match value?replicas with
| YamlValue.Number _ -> ()
| _ ->
    let at = spans.["/replicas"].Start
    printfn "replicas must be a number (line %d, column %d)" at.Line at.Column

// Failures can come back as a value too, carrying the position.
printfn "-- non-throwing parse --"
match YamlValue.TryParseWithPositions "a: [1, 2\nb: 3" with
| Ok _ -> printfn "parsed"
| Error e -> printfn "%s (line %d, column %d)" e.Message e.Pos.Line e.Pos.Column

// A Timestamp only holds a DateTimeOffset, so ParseWithMetadata also keeps the text it was
// written as (a date stays a date).
printfn "-- original timestamp text --"
let parsed = YamlValue.ParseWithMetadata text
printfn "released was written as %s" parsed.TimestampText.["/released"]
