# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

- `YamlParsed.NumberText`: the original source text of every `Number` and `Float` node (`1.10`, `1.0`, `1e3`, `0x1F`), keyed by JSON Pointer, from `ParseWithMetadata`, `TryParseWithMetadata` and `ParseMultipleWithMetadata`.

### Changed

- Adding the `NumberText` field to the `YamlParsed` record is source-breaking for code that constructs a `YamlParsed` literal, so the next release is 0.2.0.

## [0.1.0] - 2026-10-26

### Added

- Initial release: `YamlValue` DU, `Parse`/`Load`, `?` dynamic operator, `As*` accessors, round-tripping `ToString()`, anchors/aliases, multi-document streams, `YamlDocument` with comment round-tripping, and `GetPath`/`TryGetPath`/`SetPath` builders.
- Fable support: compiles to JavaScript and Python from the same source, and the package ships its F# sources under `fable/`.
- Source positions (`ParseWithPositions`) and original timestamp text (`ParseWithMetadata`).
- `IsAotCompatible` library.
