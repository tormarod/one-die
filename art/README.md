# Art

Two kinds of file live here, and Godot should only ever see one of them.

| Folder | Holds | Godot sees it? |
|---|---|---|
| `source/` | The `.aseprite` files you draw in. | **No** — put an empty file named `.gdignore` in it. |
| `sprites/` | The PNGs you export from Aseprite for the game to use. | Yes |
| `palette/` | The palette file Aseprite loads. | Doesn't matter — Godot can't import it. |

The project lives at the repo root, so this whole folder is inside it. Without a `.gdignore`, Godot
scans and imports everything it recognises in here, including any test export you save next to a
source file.

`.gdignore` is Godot's own switch. An empty file with that name makes the editor skip the folder
entirely: nothing is imported, and it disappears from the FileSystem dock. The file's contents are
ignored, so leave it empty — it does not take patterns the way `.gitignore` does.

The catch is that nothing in an ignored folder can be loaded by the game. That is exactly why the
sprites live in a separate folder without one. **Export into `sprites/`, never into `source/`.**