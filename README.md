# ArenaGame

> A 2D top-down survival shooter — built with Unity 6 & C#

![Unity](https://img.shields.io/badge/Unity-6-black?logo=unity)
![Language](https://img.shields.io/badge/C%23-2D%20Physics-239120?logo=csharp)
![Platform](https://img.shields.io/badge/Platform-PC-blue)
![Status](https://img.shields.io/badge/Status-Prototype-orange)

**[View Source](https://github.com/Phuc4D/ArenaGame)**

---

## 📸 Gameplay

> 🎬 *GIF coming soon — record with ScreenToGif and drop here*

---

## 🎮 About

ArenaGame is a top-down arena survival prototype where the player fights off escalating waves of enemies with a gun system. The focus of this project is on polymorphic enemy design and combat system architecture.

---

## 🏗️ Architecture Highlights

### Polymorphic Enemy System
Three enemy archetypes each override a shared base class with independent death behavior — no switch/case, no type-checking.

| Enemy | Death Behavior |
|---|---|
| `ExplosionEnemy` | Triggers chain-reaction area damage to nearby enemies and player |
| `EnergyEnemy` | Drops a resource orb for the player to collect |
| `HealEnemy` | Restores a portion of the player's health on death |

```csharp
// Base class — each subclass overrides OnDeath()
public abstract class Enemy : MonoBehaviour
{
    protected abstract void OnDeath();
}
```

### Wave Spawner
Time-based escalation system managing concurrent multi-archetype enemy spawning with increasing difficulty as the session progresses.

### Gun System
Full combat input loop handled in a single `Gun.cs` controller:
- Mouse-tracked aim rotation
- Projectile firing
- Magazine capacity tracking
- Manual reload state

---

## 🛠️ Tech Stack

| Category | Technology |
|---|---|
| Engine | Unity 6 |
| Language | C# |
| Physics | Unity 2D Physics |
| Version Control | Git |

---

## 📁 Project Structure

```
Assets/
├── Scripts/
│   ├── Enemy/          # Base class + 3 archetypes
│   ├── Player/         # PlayerController, Gun
│   ├── Spawner/        # EnemySpawner, wave logic
│   └── UI/             # Health bar, HUD
└── Prefabs/
```

---

## 🚀 Getting Started

```bash
git clone https://github.com/Phuc4D/ArenaGame.git
# Open in Unity Hub — requires Unity 6.x
```

---

## 👤 Author

**Nguyen Phuoc Hong Phuc**
[github.com/Phuc4D](https://github.com/Phuc4D) · [nphphucdev@gmail.com](mailto:nphphucdev@gmail.com)
