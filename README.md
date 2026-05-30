# 👻 Phantom Dash

Phantom Dash is a Unity-based 3D endless runner game where the player controls a ghost character moving through an infinite spooky track while avoiding randomly generated obstacles. The game focuses on reaction time, lane-based movement, procedural spawning, and lightweight arcade-style gameplay.

This project was created as an exploratory learning project to understand the fundamentals of game development using Unity and C#. The main goal was not to create a highly advanced commercial game, but to explore how gameplay systems, UI interactions, obstacle spawning, scoring systems, and game loops work together inside a real game engine.

---

# 🎮 Gameplay Overview

The player continuously moves forward through an endless track consisting of dynamically spawned road segments. Obstacles appear randomly across three lanes, and the player must switch lanes to survive as long as possible.

The game includes:

* Start screen UI
* Endless procedural segment spawning
* Random obstacle spawning
* Live score tracking
* Milestone celebration system
* Game Over screen
* Restart and Exit functionality
* Background spooky ambience/music

---

# 🛠️ Features

## 🔹 Endless Runner Mechanics

* Infinite road generation using procedural segment spawning
* Old segments are removed dynamically to optimize performance

## 🔹 Lane-Based Movement

The player moves across three lanes:

* Left Lane → `-2`
* Center Lane → `0`
* Right Lane → `2`

## 🔹 Random Obstacle System

* Obstacles are selected randomly from a prefab array
* Obstacles spawn dynamically on road segments
* Multiple spooky-themed obstacles integrated

## 🔹 Score System

* Score is calculated based on player distance traveled
* Live score displayed during gameplay
* Final score displayed on Game Over screen

## 🔹 Milestone Celebration System

Every 1000 points, a milestone message appears:

* `1000 Reached!`
* `2000 Reached!`
* etc.

This was added to create a stronger arcade-game feeling and improve player engagement.

## 🔹 UI System

* Start Screen
* Game Over Panel
* Live Score Display
* Restart Button
* Exit Button

## 🔹 Audio

* Spooky background ambience/music
* Looping atmospheric soundtrack

---

# 🧠 Learning Objectives of This Project

This project was mainly developed to:

* Explore Unity Game Engine workflows
* Understand prefab systems
* Learn procedural spawning concepts
* Explore UI interaction systems
* Understand collision-based gameplay logic
* Learn how standalone game builds are created
* Experiment with AI-assisted game development workflows

---

# 🤖 AI-Assisted Development

This project was developed as part of an exploratory learning process using AI assistance for:

* Understanding Unity workflows
* Generating and modifying C# scripts
* Debugging gameplay issues
* Improving UI and gameplay systems

The focus of the project was on:

* System understanding
* Gameplay design decisions
* Debugging and iteration
* Project completion and integration

rather than advanced manual C# development.

---

# 🧩 Technical Concepts Used

* Unity Engine
* C#
* Prefabs
* Procedural Generation
* Collision Detection
* UI Management
* Scene Management
* Audio Systems
* Game Loop Design

---

# 📸 Screenshots

## Start Screen

<img width="1090" height="613" alt="image" src="https://github.com/user-attachments/assets/3fe485b1-e97b-4aac-9cf6-29ca7033ef01" />

## Gameplay

<img width="517" height="480" alt="image" src="https://github.com/user-attachments/assets/8f2c8908-43c6-4223-a760-380b89d9cf26" />
<img width="499" height="486" alt="image" src="https://github.com/user-attachments/assets/8a18283d-4d7e-485a-b34a-d8409652e51e" />

## Milestone Celebration
<img width="926" height="521" alt="image" src="https://github.com/user-attachments/assets/7e25f4f3-9628-4a40-a2c5-9ffcbb8b75f3" />

## Game Over Screen

<img width="932" height="506" alt="image" src="https://github.com/user-attachments/assets/7b7d0df8-f0bb-472c-9398-69751e6c0cb0" />

---

# 🚀 Future Improvements

Possible future upgrades include:

* Difficulty progression system
* Multiple environments/themes
* Power-ups and collectibles
* Mobile controls
* High score saving system
* Particle effects and animations
* Better obstacle balancing

---

# ▶️ How To Run

1. Clone the repository
2. Open the project in Unity
3. Open the main scene
4. Press Play

---

# 📌 Project Status

✅ Completed exploratory prototype

This project represents an early exploration into game development and gameplay system design using Unity.
