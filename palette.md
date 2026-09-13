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

**Herbs n Spices** — 16 colores, de Qirlfriend.
Fuente: https://lospec.com/palette-list/herbs-n-spices

Ordenados de oscuro a claro:

​```
#17111a  #39202e  #463554  #384150
#613140  #593a31  #55516f  #83443e
#6b6657  #6e7e8d  #9a945c  #c98d3f
#ab99a4  #90b5c6  #dac282  #f5efe8
​```

### Las rampas

- **Azul:** `384150` → `6e7e8d` → `90b5c6`
- **Cálida:** `593a31` → `83443e` → `c98d3f` → `dac282`
- **Oliva:** `6b6657` → `9a945c`
- **Oscuros:** `17111a`, `39202e`, `463554`, `55516f`

### Dos reglas que salen de esta paleta

1. **El fondo es `17111a` o `39202e`.** Nunca uno de los cuatro que rondan el 25 de brillo
   (`463554`, `384150`, `613140`, `593a31`): son el extremo oscuro de cuatro rampas distintas y,
   sin color, son el mismo. Si el fondo fuera uno, los otros tres desaparecerían encima.
2. **`c98d3f` es el único color gritón.** Es el más saturado con diferencia, y el ojo va ahí
   primero siempre. Guárdalo para lo que quieras que el jugador mire. Si lo usas en todo, no
   significa nada.

Cárgala en Aseprite (`.gpl` desde Lospec) para no poder elegir un color de fuera por accidente.

## The rule

One resolution, one palette, no exceptions. Not for a background, not for a UI element, not for one
special effect.

This is the whole of what makes a set of assets look like they belong together, and it does not
require being good at drawing. Incoherent and skilled reads as broken. Clumsy and coherent reads as
style.
