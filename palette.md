# The two decisions

Everything in this project is drawn against these. Nothing else gets to disagree with them.

Fill this in during week 0, before drawing anything.

## Resolution

**320 × 180.**

Chosen because it scales by whole numbers to both targets: ×6 is exactly 1920 × 1080, and ×4 is
exactly 1280 × 720, which fits a Steam Deck screen with clean letterboxing. Whole-number scaling means
no resampling, so a pixel stays a square.

The cost, so it is not a surprise later: at this size, type has to be a pixel font. Any typeface with
real curves will mush.

| Setting | Value | Where |
|---|---|---|
| Viewport width | `320` | Project Settings → Display → Window |
| Viewport height | `180` | same |
| Stretch mode | `canvas_items` | same |
| Stretch aspect | `keep` | same |
| Default texture filter | `Nearest` | Project Settings → Rendering → Textures |

## Palette

**Summers Past-16** — 16 colores, de keidding.
Fuente: https://lospec.com/palette-list/summers-past-16

Ordenados de oscuro a claro:

​```
#320011  #5f3a60  #933942  #c33846
#627057  #876672  #5e80b2  #c66f5e
#8da24e  #e78c5b  #6db7c3  #b7a39d
#d2cb3e  #e8bf92  #f7d554  #ece8c2
​```

### Las rampas

- **Vino/rojo:** `320011` → `933942` → `c33846` → `876672`
- **Cálida (terracota):** `c66f5e` → `e78c5b` → `b7a39d` → `e8bf92`
- **Oliva/amarillo:** `627057` → `8da24e` → `d2cb3e` → `f7d554`
- **Azul/verde-azulado:** `5e80b2` → `6db7c3`
- **Extremos:** `5f3a60` (violeta oscuro) y `ece8c2` (crema casi blanco) — no encajan en ninguna
  rampa, son los dos casos límite de la paleta.

### Dos reglas que salen de esta paleta

1. **El fondo es `320011`.** Es el único tono casi negro de la paleta: el siguiente más oscuro,
   `5f3a60`, ya es un morado claramente reconocible, así que aquí no hay dos oscuros que se puedan
   confundir entre sí.
2. **`f7d554` es el único color gritón.** Es el de mayor diferencia entre su canal más claro y el
   más oscuro de los 16, y el más brillante con diferencia. Guárdalo para lo que quieras que el
   jugador mire primero. Si lo usas en todo, no significa nada.

Cárgala en Aseprite (`.gpl` desde Lospec) para no poder elegir un color de fuera por accidente.

## The rule

One resolution, one palette, no exceptions. Not for a background, not for a UI element, not for one
special effect.

This is the whole of what makes a set of assets look like they belong together, and it does not
require being good at drawing. Incoherent and skilled reads as broken. Clumsy and coherent reads as
style.
