## 📌 Project Reflection

---

<details>
<summary><strong>📦 1. What we built</strong></summary>
</br>

We built a console-based adventure game

# 🐱 Forest Cat Adventure

The player controls a cat trying to survive in a dangerous forest filled with random events and monster encounters. The game includes:

- A start menu system
- Cat creation with different breeds and stats
- A main gameplay loop with exploration, rest, and status checks
- Random events during exploration
- A turn-based combat system with options like attacking, running away, and rest

The goal of the game is to survive as long as possible in the forest.

# 🌲 Game Flow

```text
Start Menu
   ↓
Cat Creation
   ↓
Main Game Menu
   ↓
Walk / Rest / Status
   ↓
Random Forest Event
   ↓
Fight Monster or Continue Exploring
   ↓
Win or Game Over
```

# 🎮 Console Menu Plan – Forest Cat Adventure

### 🏠 Start Menu

1. Start new game
2. Read game instructions
3. Exit game

### 🐾 Cat Creation Menu

1. Choose cat name
2. Choose cat breed

```text
   - Forest Cat: balanced
   - Tiger Cat: strong attack
   - Persian Cat: more health
   - Black Cat: higher luck
```

### 🌲 Main Game Menu

1. Walk through the forest
2. Rest
3. Show cat status
4. Exit game

### 🍃 Walk Event Menu

When the cat walks, one random event happens:

```text
1. Monster appears
(The idea is under development)
2. Cat finds food (Recover health)
3. Cat finds safe place (Small rest bonus)
4. Nothing happens
```

### ⚔️ Fight Menu

1. Attack monster
2. Try to run away
3. Meow to scare monster or do nothing
4. Show health

### 😴 Rest Menu

1. Rest and recover health
2. Return to main menu

</details>

---

<details>
<summary><strong>🤝 2. How collaboration worked</strong></summary>
</br>

<strong>Platform & Backlog</strong>
</br>
Firstly, in order to learn how to handle a team on another platfrom, we decided to work with Github instead of Azure DevOps which we already explored during the school group project.

We started with open a new orgnization, and invited every team members. Then we created a repo and a project inside the org, and impletement the user stories and the related tasks in the backlog. As it is a smaller-sized project, we didn't create any springt for it.

<strong>Branch Policy & merge conflicts</strong>
</br>
As we learned from the school project, it is important to protect the main branch to reduce the merge conflicts and improve the accountibility. We created the rules to prevent direct push into main, and every pull request would require at lease one reviwer.

When a merge conflict happens, the reviwers would help to resolve it in Github directly.

<strong>Mob programming </strong>
</br>
In order to adpat the mob programming method, we selected a few tasks and worked together, we rotated the developer's role and the rest watched and guided the person who coded.

We communicated vis Discord to make sure our code worked together.

</details>

---

<details>
<summary><strong>🔧 3. How we used Git</strong></summary>

We used Git for version control by:

- Creating separate branches for features

```text
  git checkout -b <branch-name>
```

- Committing changes frequently

```text
  git commit -am "commit message"
```

- Merging completed features into the main branch
- Tracking the commit histroy and resolving merge conflicts

</details>

---

<details>
<summary><strong>⭐ 4. What worked well</strong></summary>

- As a rework on the first labb we had in this study program, now it becomes very easy to understand and debug the codes.
- We built the structure and different functions smoothly.
- The Backlog helped us stay organized and pick tasks effectively.
- Much better understanding of which behavior might cause merge conflicts
- Commit often and always pull before work

</details>

---

<details>
<summary><strong>🔄 5. What we would do differently</strong></summary>

- Improve early Git workflow (more consistent branch naming)
- Add better input validation
- Spend more time balancing game mechanics

</details>
