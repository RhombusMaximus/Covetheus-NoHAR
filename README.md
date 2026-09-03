# Covetheus (No HAR) — RimWorld 1.6

The Covetheus mod without the Humanoid Alien Races (HAR) dependency. Features the Artificial Person (Android) race, USCSS Colony mission scenario, and Covetheus apparel — all using vanilla RimWorld systems.

Original mod by Lelbaro, updated by Zaljerem, HAR dependency removed by RhombusMaximus.

## Credits

### Original Mod
- **Lelbaro** — Original Covetheus mod (race, apparel, scenario, art)
- https://steamcommunity.com/sharedfiles/filedetails/?id=2077371272

### 1.4/1.5 Update
- **Zaljerem** — Version updates and maintenance

### 1.6 Port & HAR Removal
- **RhombusMaximus** — HAR dependency removal, 1.6 migration, bug fixes, texture fixes

### Special Thanks
- The RimWorld modding community
- Ludeon Studios for RimWorld 1.6's native render tree system (made HAR removal possible)

## Features

### Artificial Person Race
- **Android_Walter** — "Artificial Person" android race based on the Alien franchise's Walter/David series
- Uses vanilla `ThingDef` with `ParentName="Human"` — no HAR required
- `renderTree>Humanlike` for proper rendering
- Custom body definition (Android_Walter BodyDef)
- Gender-neutral (not male-only like original HAR version)
- No life stages (single adult form)
- High immunity gain, pain shock threshold, toxic resistance
- Low flammability, no leather/meat (synthetic)
- No sleep needed
- Custom backstories (Android Crew, Android Model, USCSS crew roles)

### USCSS Colony Mission Scenario
- Start with 7 human colonists + 1 Artificial Person
- Arrive in drop pods
- Starting equipment: F90 rifles, survival meals, medicine, components, rice
- Custom game start dialog
- Backstories for all crew roles: Terraformist, Pilot, Bridge Officer, Chief Science Officer, Military Security

### Apparel
- **USCSS Hoodies** — Different designs for male and female colonists
- **Jumpsuits** — Casual and gray variants for colonist wear
- **Trapper Hats** — Frontier headgear
- **Backpack** — With camera and solar panel attachment
- All apparel has proper body-type-specific textures (Male, Female, Thin, Hulk, Fat, etc.)

## What Was Removed (HAR Features)
The following HAR-specific features were removed during the HAR dependency removal:
- Forced traits (Emotionless, Kind, Tough) — may be restored via Harmony patches
- Cannot receive thoughts — may be restored via Harmony patches
- No relations — may be restored via Harmony patches
- Custom head textures — may be restored via renderTree customization
- Male-only gender — now gender-neutral
- Life stages — now single adult form

These features may be restored in future updates using Harmony patches instead of HAR.

## Bug Fixes in This Version
- Removed HAR `modDependencies` and `loadAfter`
- Converted `AlienRace.ThingDef_AlienRace` to vanilla `ThingDef`
- Converted `AlienRace.AlienBackstoryDef` to vanilla `BackstoryDef`
- Fixed `renderTree>Humanlike` for proper pawn rendering
- Fixed missing apparel textures (19 textures added for all body types)
- Removed blue Casual Jumpsuit (missing south/west textures)
- Removed Engineer Jumpsuit (placeholder texture)
- Fixed backpack base textures (Graphic_Multi needs base textures)
- Fixed all `Ui/` paths to `UI/` (case sensitivity)
- Fixed `ScenPart_StartingHumanlike` (removed in 1.6) — using `CustomScenParts.ScenPart_AddPawnKind`
- Fixed body type assignment — backstories now use `bodyTypeMale`/`bodyTypeFemale` (null = invisible pawns)
- Fixed scenario loading errors
- Cleaned up old version directories (1.3, 1.4, 1.5)

## Compatibility
- **No HAR dependency** — works standalone
- Compatible with most apparel and race mods
- Compatible with Reel's Facial Animation Textures (planned improvement)
- Uses vanilla rendering pipeline

## Requirements
- RimWorld 1.6
- No other mods required

## Based On
Original mod: [Covetheus](https://steamcommunity.com/sharedfiles/filedetails/?id=2077371272) by Lelbaro