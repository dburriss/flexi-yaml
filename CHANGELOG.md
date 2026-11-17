# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [0.2.1] - 2026-11-17

### Fixed

- The packed FSharp.Core dependency is now an explicit 8.0.403 minimum instead of the SDK default (0.2.0 accidentally required 11.0.101).

## [0.2.0] - 2026-11-17

### Added

- `YamlParsed.NumberText`: the original source text of every `Number` and `Float` node (`1.10`, `1.0`, `1e3`, `0x1F`), keyed by JSON Pointer, from `ParseWithMetadata`, `TryParseWithMetadata` and `ParseMultipleWithMetadata`.

### Changed

- Adding the `NumberText` field to the `YamlParsed` record is source-breaking for code that constructs a `YamlParsed` literal, so the next release is 0.2.0.
- Retargeted `net8.0` to `net10.0`: the library now targets `netstandard2.0` and `net10.0`, and the tests and Fable project target `net10.0`. `IsAotCompatible` is now set only for the `net10.0` target.

## [0.1.0] - 2026-10-26

### Added

- Initial release: `YamlValue` DU, `Parse`/`Load`, `?` dynamic operator, `As*` accessors, round-tripping `ToString()`, anchors/aliases, multi-document streams, `YamlDocument` with comment round-tripping, and `GetPath`/`TryGetPath`/`SetPath` builders.
- Fable support: compiles to JavaScript and Python from the same source, and the package ships its F# sources under `fable/`.
- Source positions (`ParseWithPositions`) and original timestamp text (`ParseWithMetadata`).
- `IsAotCompatible` library.
