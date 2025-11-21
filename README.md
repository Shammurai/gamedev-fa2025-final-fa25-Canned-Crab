# Bottega
**Team Canned Crab | GameDev - Fall 2025**

Play as an artist's apprentice in Renaissance Italy who has been delegated to handling menial household chores. Complete your tasks quickly and efficiently to prove to your master that you can take on higher-level artistic work and eventually complete your apprenticeship.

## Authors
* Herbert Steet (Communication Arts) - steeth@vcu.edu
* Alexia Slate (Communication Arts) - slateat@vcu.edu
* Tyler Ricks (Computer Science) - rickstd@vcu.edu
* Jacob Stephens (Computer Science) - stephensj@vcu.edu

## Game Description

Bottega (Italian for "workshop" or "studio") is a fast-paced task management game set in a Renaissance artist's workshop. You are an apprentice to this artist. Despite your aspirations, the artist only has you doing menial tasks like cleaning the workshop or providing supplies to other artists. 

It seems the only thing to do is to keep working. Maybe, the respect you earn will lead you places...

### Unique Gameplay Features
 
**Fast-Paced Minigame Management:** To keep the workshop clean, tasks are constantly given to you. You might find the right brush for one of the artist, collect some paints, scrub some walls, and more. However, the better you do in a given day, the more you will get to do apprenticeship-related tasks.

**Spur-of-the-Moment Decision Making:** React quickly to changing priorities and unexpected demands from your master. Time management is crucial.

**Dynamic Progression System:** Your performance day to day determines the sets of tasks that you  are given the next day. If you keep up with all the artist's supply requests on day one, then on day two, you may be asked to prepare a canvas. The idea is that the more respect you earn from the artists, the more you will get involved in their work.


### Goal

Further your apprenticeship and actually work on paintings.

## Game Loop

1. **Receive Task:** Your master assigns you a task based on your current stage and previous performance
2. **Complete Task Quickly:** Race against the clock to finish the task efficiently
3. **Repeat Until Day End:** Continue completing tasks throughout the workday
4. **Performance Evaluation:** Your score determines tomorrow's responsibilities and potential stage advancement

## Progression System

### Three Stages

**Stage 1**
Keep the workshop clean by sweeping, cleaning tables, washing brushes, fetching supplies, and more

**Stage 2**
Get more involved with the artist's work by preparing canvases, creating supplies, and mixing paints.

**Stage 3**
Directly contribute to the artist's work by filling in sections of paintings, making decisions for sections, and adding details.

### Win/Fail Conditions

**Short-Term Outcomes (Daily):**
* **Fail:** Not enough Tasks completed, or tasks were not completed with enough quality
* **Proficient Win:** Enough tasks were completed, but may not have reached quality standards
* **Advanced Win:** Many tasks were completed, and the quality meets/exceeds standards

**Ultimate Outcomes (Career):**
* **Ultimate Fail:** 2 days in a row failed (Apprenticeship terminated - Game Over)
* **Ultimate Win:** Achieve advanced win on highest difficulty of Stage 3 (Apprenticeship completed!)

## Platform & Controls

* **Platform:** Windows PC
* **Input:** Mouse & Keyboard

## Visual Style

The game is stylized after renaissance ink sketches

## Target Audience

* Art enthusiasts and students
* Renaissance history fans
* Fans of time management and minigames

## Important Links

* **Game URL:**  https://play.unity.com/en/games/95717e68-8925-4f23-8ac2-8f9c29707528/bottega
* **GitHub Repository:** https://github.com/Shammurai/gamedev-fa2025-final-fa25-Canned-Crab
* **Short Video:** https://drive.google.com/file/d/1GY36K1MNX_ybIgjYDqxqYQvE9TtztHAV/view?usp=drive_link
* **Unity Cloud Project:** https://cloud.unity.com/home/organizations/2475903349698/projects/13778784-2444-4b4c-a952-b71d00155479

## Repository Structure

```
./unity/      - Unity game files and project assets
```

## Development Notes

This project was developed as part of the Fall 2025 GameDev course. The game emphasizes rapid task completion, time management, and progression through skill-based gameplay.

### How to Build & Run

Go to the Game URL to play it on Unity Play (we will add it to itch.io later)

### Contributing

This is a class project with a fixed team, but we welcome feedback and suggestions! Please open an issue if you encounter any bugs or have ideas for improvement.

---

