# One Die

Learning Godot 4, C# and pixel art by shipping one small, finished dice game in six weeks.

**The plan, week by week:** https://claude.ai/code/artifact/eab6c62f-fb99-42c1-8550-ada3a7a711e2

## The game

One enemy, one table, one screen. Roll three dice. Spend each as an attack or a block. The enemy hits
back. Someone reaches zero. Title screen, play, win or lose, restart.

That is all of it. It is a rehearsal for Roguedice's combat view without being Roguedice, and nothing
in it has to be kept. Roguedice's Godot side is C# too, so everything learned here carries across.

## Start here

1. **The Godot project is the repo root**, created by hand with the **.NET build** of Godot 4.7.2. The
   standard build cannot run C#.
2. Set it up: viewport `320` × `180`, stretch mode `canvas_items`, aspect `keep`, and
   **Rendering → Textures → Default Texture Filter → `Nearest`**. That last one is what makes pixel
   art crisp instead of a soft grey smudge, and it is the mistake everybody makes first.
3. **Point Godot at VS Code:** *Editor Settings → Dotnet → Editor → External Editor → Visual Studio
   Code*. Godot's own script editor only colours C# — no autocomplete, no errors.
4. Keep `one-die.csproj` on `net10.0`. .NET 10 is the only version installed.
5. Choose a palette on [Lospec](https://lospec.com/palette-list) and write it into `palette.md`.
6. `git init`, and commit the empty project.

## Scope rules

These are the plan. The weeks are only where the work goes.

1. One resolution and one palette. No exceptions, not once, not even for a background.
2. One enemy. One room. No map, no shop, no items, no levels, no saving, no settings menu.
3. No procedural generation and no content system. Numbers live in the script that reads them.
4. **No agent.** Every line and every pixel is mine. See `CLAUDE.md`.
5. A feature idea goes in `questions.md`. It does not go in the game.
6. If a week's build is not done by its weekend, cut the build. Never extend the week.
7. Ship in week 6 even if it is ugly. An ugly finished game teaches more than a beautiful
   unfinished one.

## Layout

| Path | What it holds |
|---|---|
| repo root | The Godot project: `project.godot`, `one-die.csproj`, and the scenes and C# scripts. |
| `art/` | Aseprite sources and exported sprites. See `art/README.md`. |
| `notes/` | One file per week: what I learned, what confused me. Copy `week-0.md` as a template. |
| `palette.md` | The two decisions everything else depends on: resolution and palette. |
| `questions.md` | Where a question goes when the one-hour rule fires. |

## The one-hour rule

Twenty minutes alone, then the official docs, then search with "godot 4" and "C#" in the query. Most
answers will still be GDScript — the docs show the C# version in a tab beside most examples, which is
the quickest way to translate. After an hour, stop: write the question in `questions.md`, skip the
item, move on. One bug must never eat an evening. That is how hobby projects die.
