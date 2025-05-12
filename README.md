# Vibe Quest  
**Level Up Your Life: The Gamified Personal Growth Tracker**  
**Author:** Vibe Rantz  
**Version:** Draft 1.0  
**Date:** April 18, 2025  

---

## 🎯 Introduction

### 1.1 Purpose  
This document outlines the functional and non-functional requirements of the *Vibe Quest* application. Special focus is given to areas that are conceptually challenging, such as gamification logic, translating personal growth into digital progress, and creating a motivational user experience.

### 1.2 Scope  
*Vibe Quest* is a web-based application designed to transform personal development into an RPG-like experience. It targets users who struggle with motivation and are seeking a more engaging, creative way to track progress and build better habits.

---

## 🧠 Conceptually Difficult Areas

### 2.1 Gamification of Personal Tasks  
One of the hardest aspects to implement is giving real-life actions meaningful game mechanics.
- Users manually input custom tasks (e.g., “Go for a walk,” “Sketch for 30 min”).
- Tasks grant XP and are tied to skill categories: Mind, Body, Creativity, and Focus.
- Completing tasks awards XP and levels up the user.

**Challenge:** Making the system feel like real progress, NOT just checkbox ticking. XP values and level-up pacing must feel natural and rewarding.

---

### 2.2 Skill Trees & Progress Mapping  
- Skill Trees will visually show growth across categories like Creativity, Focus, Health, and Mental Resilience.
- XP from tasks gets distributed into these areas.

**Challenge:** Users must be able to easily see the connection between their actions and their growth. Cause and effect must be clear in the UI.

---

### 2.3 Leveling System  
- Users level up based on total XP earned.
- XP thresholds grow with each level.
- Rewards may be visual, cosmetic, or motivational.

**Challenge:** Creating a balanced XP curve that keeps users motivated without making progress feel too easy or impossible.

---

### 2.4 Journal Reflections & Mental Growth  
- Users can write daily or weekly reflections.
- Journals are tied to growth, not just storage.
- Completing reflections may grant XP or “Mental Clarity” bonuses.

**Challenge:** Emotional growth is hard to quantify. We need to show this value clearly without making it feel like we're trivializing mental health.

---

### 2.5 Why This Isn’t Just a To-Do List  
- The core loop: input quests → complete → earn XP → level up → grow skills.  
- Encourages deeper self-reflection and habit consistency.

**Challenge:** Users may assume it’s just another productivity app. We must emphasize the RPG experience, gamified motivation, and visual progress.

---

## 🛠️ Tools & Technology

- **Frontend:** Blazor WebAssembly  
- **Backend:** ASP.NET Core  
- **Auth:** ASP.NET Identity  
- **Database:** SQLite *(tentative; still under research)*  
- **Styling:** Bootstrap 5 or TailwindCSS  
- **Version Control:** GitHub  
- **Hosting (Dev):** localhost → GitHub Pages *(for front-end)*

---

## 🚀 Future Expansion Areas

- Boss Battles: Multi-day milestone quests  
- Achievements: Visual rewards for consistency  
- Companion mobile app  
- Patreon integration: Exclusive quests and digital unlockables  

---

> “Grind XP. Grow IRL.” – *Vibe Rantz*


# 📝 Software Requirements Specification (SRS) – Milestone 1 Update
**Project:** Vibe Quest – Gamified Personal Growth Tracker  
**Milestone 1:** User Account Creation & Authentication System  
**Version:** 1.1  
**Date:** 2025-04-25  
**Author:** Vibe Rantz  

---

## 📌 Changelog

| Date       | Version | Changed By   | Description                                                   |
|------------|---------|--------------|---------------------------------------------------------------|
| 2025-04-25 | 1.1     | Vibe Rantz   | Added user registration and login system to functional scope  |
| 2025-04-25 | 1.1     | Vibe Rantz   | Defined “Hero Name” as the custom user identifier             |
| 2025-04-25 | 1.1     | Vibe Rantz   | Updated system features and architecture to include auth flow |

---

## 1.0 📋 Functional Requirements (Updated)

- **FR-01**: The system shall allow users to register using an email, password, and Hero Name.
- **FR-02**: The system shall ensure each Hero Name is unique.
- **FR-03**: The system shall validate password strength (minimum 8 characters).
- **FR-04**: The system shall allow users to log in and log out securely.
- **FR-05**: The system shall display error messages when registration or login fails.

---

## 2.0 🚀 System Features (New Section Added)

### 2.1 – User Authentication Module

- **Description**: Allows users to create accounts and authenticate into the system.
- **Inputs**: Email, Password, Hero Name  
- **Outputs**: Confirmation message on success, error feedback on failure  
- **Priority**: High  
- **Dependencies**: Database connection, UI registration form  

---

## 3.0 👤 User Classes and Characteristics (Updated)

| User Type       | Description                                        |
|------------------|----------------------------------------------------|
| New User         | Registers a new account with email and Hero Name   |
| Returning User   | Logs in using previously registered credentials    |
| Admin (Future)   | Manages user roles and permissions                 |

---

## 4.0 📈 Non-Functional Requirements (Updated)

- Passwords must be securely stored using hashing (e.g., bcrypt).
- Login and registration operations must respond in under 2 seconds.
- The system must prevent duplicate Hero Names.

---

## 5.0 🧩 System Architecture
![AuthSystemDiagram](https://github.com/user-attachments/assets/bc9481c4-bcb1-47ac-a40a-f0698263f65a)

Project: Vibe Quest – Gamified Personal Growth Tracker
Milestone 2: Task Creation, XP Tracking, and Skill Allocation
Version: 1.2
Date: 2025-05-04
Author: Vibe Rantz

📌 Changelog
Date	Version	Changed By	Description
2025-05-04	1.2	Vibe Rantz	Added Task Creation and XP Logic to functional scope
2025-05-04	1.2	Vibe Rantz	Introduced Skill Categories: Mind, Body, Creativity, Focus
2025-05-04	1.2	Vibe Rantz	Outlined the backend logic for XP calculation and skill point allocation
2025-05-04	1.2	Vibe Rantz	Began prototyping the Skill Tree visual and XP display components

1.0 📋 Functional Requirements (Extended)
FR-06: The system shall allow users to create custom tasks and assign them to a skill category.

FR-07: The system shall calculate XP based on task difficulty and frequency.

FR-08: The system shall update user XP and level after task completion.

FR-09: The system shall reflect XP gain in the appropriate skill category (e.g., Body for workouts).

FR-10: The system shall persist task data and XP history in the database.

2.0 🚀 System Features (Extended)
2.2 – Task Engine & XP Calculator
Description: Enables task creation, tracking, and XP generation based on skill type.

Inputs: Task name, category, difficulty level

Outputs: XP reward, skill progress update

Priority: High

Dependencies: User authentication, skill data structure, database schema

2.3 – Skill Tracker (Prototype Phase)
Description: Displays user growth across four main categories: Mind, Body, Creativity, and Focus.

Feature Preview: Graph or bar-based progress indicator, color-coded per category.

Priority: Medium (MVP Preview Only)

3.0 👤 User Classes and Characteristics (No Change from 1.1)
4.0 📈 Non-Functional Requirements (Additional)
Skill and XP updates must reflect in UI within 1.5 seconds of task completion.

Task entries must support basic CRUD operations (Create, Read, Update, Delete).

UX feedback (e.g., animation or sound cue) should confirm XP gain instantly.

5.0 🧩 System Architecture (Expanded)
Frontend integration for task forms and skill bars is in development.

XP logic lives server-side with API endpoints handling task completion and XP updates.

SQLite schema includes tables for: Users, Tasks, SkillProgress, and JournalEntries.


| Date       | Version | Changed By   | Description                                                             |
|------------|---------|--------------|-------------------------------------------------------------------------|
| 2025-05-11 | 1.3     | Vibe Rantz   | Implemented in-memory task logic and XP tracker in Blazor WASM app     |
| 2025-05-11 | 1.3     | Vibe Rantz   | Added TaskBoard UI and XP progress bar visualization on Home page      |
| 2025-05-11 | 1.3     | Vibe Rantz   | Registered and injected TaskService using singleton DI pattern          |
