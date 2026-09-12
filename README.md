# One Die

Learning Godot 4, GDScript and pixel art by shipping one small, finished dice game in six weeks.

**The plan, week by week:** https://claude.ai/code/artifact/eab6c62f-fb99-42c1-8550-ada3a7a711e2

## The game

One enemy, one table, one screen. Roll three dice. Spend each as an attack or a block. The enemy hits
back. Someone reaches zero. Title screen, play, win or lose, restart.

That is all of it. It is a rehearsal for Roguedice's combat view without being Roguedice, and nothing
in it has to be kept.

## Start here

1. **Create the Godot project yourself**, in `game/`. Godot 4.x standard build — not the .NET one.
   Doing this by hand is week 0's first task, which is why it is not already here.
2. Set it up: viewport `320` × `180`, stretch mode `canvas_items`, aspect `keep`, and
   **Rendering → Textures → Default Texture Filter → `Nearest`**. That last one is what makes pixel
   art crisp instead of a soft grey smudge, and it is the mistake everybody makes first.
3. Choose a palette on [Lospec](https://lospec.com/palette-list) and write it into `palette.md`.
4. `git init`, and commit the empty project.

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
| `game/` | The Godot project. Created by hand in week 0. |
| `art/` | Aseprite sources. Exported PNGs go into `game/`, the `.aseprite` files stay here. |
| `notes/` | One file per week: what I learned, what confused me. Copy `week-0.md` as a template. |
| `palette.md` | The two decisions everything else depends on: resolution and palette. |
| `questions.md` | Where a question goes when the one-hour rule fires. |

## The one-hour rule

Twenty minutes alone, then the official docs, then search with "godot 4" in the query. After an hour,
stop: write the question in `questions.md`, skip the item, move on. One bug must never eat an evening.
That is how hobby projects die.
