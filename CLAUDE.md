# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Forem](https://www.forem.com/) platform API (powers dev.to and other Forem communities), auto-generated from the official Forem OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `Forem` package name.

## Build Commands

```bash
# Build the solution
dotnet build Forem.slnx

# Build for release (also produces NuGet package)
dotnet build Forem.slnx -c Release

# Run integration tests (requires FOREM_API_KEY env var)
dotnet test src/tests/IntegrationTests/Forem.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Forem && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Forem/Generated/`.

1. `src/libs/Forem/openapi.yaml` -- the Forem OpenAPI spec (fetched from `developers.forem.com`)
3. `src/libs/Forem/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Forem/` | Main SDK library (`ForemClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Forem API |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### Key Conventions

- No hand-written extension files -- the SDK is purely generated code
- The client class is named `ForemClient`
- The namespace is `Forem`

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
