# Squad × Blazor Portfolio

> **Un portfolio Blazor WebAssembly construit avec une équipe d'agents IA orchestrés par Squad.**
> Ce projet est à la fois un portfolio personnel fonctionnel et une démonstration concrète de [Squad](https://github.com/bradygaster/squad), le framework d'équipes d'agents IA de Brady Gaster.

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com)
[![Blazor](https://img.shields.io/badge/Blazor-WebAssembly-512BD4?logo=blazor)](https://blazor.net)
[![Squad](https://img.shields.io/badge/Squad-AI%20Agents-FF6B35)](https://github.com/bradygaster/squad)
[![MudBlazor](https://img.shields.io/badge/MudBlazor-v6-594AE2)](https://mudblazor.com)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

---

## Présentation du projet

### Qu'est-ce que ce projet ?

Ce repository contient le code source d'un **portfolio personnel en Blazor WebAssembly**, développé en utilisant **Squad** comme équipe de développement IA. L'objectif est double :

1. **Portfolio fonctionnel** — Un site web professionnel déployé sur GitHub Pages, présentant projets, compétences et informations de contact
2. **Démonstration de Squad** — Une illustration pratique de comment des agents IA spécialisés (Lead, Frontend, Backend, Tester, Scribe) collaborent sur un projet réel sous direction humaine

### Pourquoi Squad ?

Squad transforme la façon de développer en formant une **équipe virtuelle d'agents IA** intégrée directement dans votre workflow Git. Contrairement à un simple assistant IA, Squad maintient une mémoire persistante, des rôles définis, et un log de toutes les décisions prises — exactement comme une vraie équipe agile.

```
Vous définissez les objectifs
        ↓
Lead Agent analyse et planifie
        ↓
Frontend / Backend / Tester travaillent en parallèle
        ↓
Scribe documente tout
        ↓
Vous reviewez et approuvez
```

---

## Architecture technique

### Stack

| Couche | Technologie | Version |
|--------|-------------|---------|
| Framework | Blazor WebAssembly | .NET 8 |
| UI Components | MudBlazor | 6.x |
| Tests | bUnit | 1.x |
| Orchestration IA | Squad CLI | latest |
| CI/CD | GitHub Actions | — |
| Hébergement | GitHub Pages | — |

### Structure du projet

```
squad-blazor-portfolio/
│
├── .squad/                          # Configuration Squad (agents IA)
│   ├── team.md                      # Composition de l'équipe
│   ├── routing.md                   # Règles de routing des tâches
│   ├── decisions.md                 # Log de toutes les décisions
│   └── agents/
│       ├── lead/                    # Agent Lead (architecture, coordination)
│       ├── frontend/                # Agent Frontend (Blazor, CSS, UX)
│       ├── backend/                 # Agent Backend (services, modèles)
│       ├── tester/                  # Agent Tester (bUnit, validation)
│       └── scribe/                  # Agent Scribe (docs, décisions)
│
├── src/
│   └── SquadPortfolio/              # Projet Blazor WASM principal
│       ├── Components/
│       │   ├── Layout/              # MainLayout, NavMenu
│       │   └── Pages/               # Home, About, Projects, Contact
│       ├── Models/                  # ProjectModel, SkillModel
│       ├── Services/                # PortfolioDataService
│       ├── wwwroot/                 # Assets statiques (CSS, images)
│       ├── App.razor
│       ├── Program.cs
│       └── SquadPortfolio.csproj
│
├── tests/
│   └── SquadPortfolio.Tests/        # Tests bUnit
│
├── docs/
│   ├── decisions/                   # ADR (Architecture Decision Records)
│   └── squad-logs/                  # Logs des sessions Squad
│
├── .github/
│   └── workflows/
│       └── deploy.yml               # CI/CD GitHub Actions
│
├── PROJECT_RECAP.md                 # Vision et état du projet
└── README.md                        # Ce fichier
```

### Architecture des composants Blazor

```
App.razor
└── MainLayout.razor
    ├── NavMenu.razor (sticky, dark/light toggle)
    └── Pages/
        ├── Home.razor
        │   ├── HeroSection (nom, titre, CTA)
        │   └── SummarySection (résumé rapide)
        ├── About.razor
        │   ├── BioSection
        │   ├── SkillsGrid
        │   └── ExperienceTimeline
        ├── Projects.razor
        │   ├── FilterBar (par technologie)
        │   └── ProjectCard × N
        └── Contact.razor
            └── ContactForm (mailto / EmailJS)
```

---

## Technologies utilisées

### Blazor WebAssembly
Blazor WASM permet d'écrire du **C# qui s'exécute dans le navigateur** via WebAssembly. Avantages pour un portfolio :
- Déployable comme un site statique (GitHub Pages, Netlify, Azure Static)
- Pas de serveur à maintenir
- Réutilisation des compétences .NET existantes
- Composants réactifs sans JavaScript

### Squad (AI Agent Teams)
Squad est un framework open source qui crée des **équipes d'agents IA persistantes** dans votre projet Git. Chaque agent a :
- Un **charter** (rôle et responsabilités)
- Un **historique** (apprentissage cross-sessions)
- Des **décisions documentées**

### MudBlazor
Librairie de composants Material Design pour Blazor. Utilisée pour :
- Grilles responsives
- Cards de projets
- Navigation
- Thème Dark/Light intégré
- Timeline pour l'expérience

---

## Instructions d'installation

### Prérequis

```bash
# .NET 8 SDK
dotnet --version  # doit afficher 8.x.x

# Node.js (pour Squad)
node --version    # doit afficher 18+

# GitHub Copilot CLI (pour Squad)
gh extension install github/gh-copilot
gh copilot --version

# Squad CLI
npm install -g @bradygaster/squad-cli
squad --version
```

### Installation du projet

```bash
# 1. Cloner le repository
git clone https://github.com/<votre-username>/squad-blazor-portfolio.git
cd squad-blazor-portfolio

# 2. Restaurer les dépendances .NET
dotnet restore src/SquadPortfolio/SquadPortfolio.csproj

# 3. Vérifier la configuration Squad
squad doctor

# 4. Lancer en développement
dotnet watch run --project src/SquadPortfolio/SquadPortfolio.csproj
```

L'application sera disponible sur `https://localhost:5001`.

---

## Conventions du projet

### Conventions Git

| Convention | Règle |
|------------|-------|
| Branches | `feature/nom-feature`, `fix/description`, `docs/sujet` |
| Commits | Conventional Commits (`feat:`, `fix:`, `docs:`, `test:`) |
| PR | Description obligatoire, review avant merge |
| `main` | Branche de production — toujours stable et déployable |
| `dev` | Branche de développement — intégration des features |

### Conventions de code

```csharp
// Composants Blazor : PascalCase
// Fichier : ProjectCard.razor
// Composant : <ProjectCard />

// Modèles : suffixe "Model"
public record ProjectModel(string Title, string Description, string[] Tags);

// Services : suffixe "Service", injectables
public class PortfolioDataService { ... }

// CSS : BEM simplifié avec préfixe de composant
.project-card { }
.project-card__title { }
.project-card--featured { }
```

### Conventions Squad

- **Un agent = une responsabilité** — ne pas mélanger les rôles
- **Décisions documentées** — tout choix architectural va dans `.squad/decisions.md`
- **Historique commité** — `.squad/agents/*/history.md` dans Git pour persistance
- **Humain en dernier** — l'agent propose, l'humain approve avant merge

---

## Commandes utiles

### Développement

```bash
# Lancer le projet
dotnet watch run --project src/SquadPortfolio

# Build de production
dotnet publish src/SquadPortfolio -c Release -o ./publish

# Lancer les tests
dotnet test tests/SquadPortfolio.Tests

# Vérifier le build
dotnet build src/SquadPortfolio
```

### Squad

```bash
# État de l'équipe
squad status

# Trier les tâches en attente
squad triage

# Mode surveillance (auto-dispatch)
squad watch

# Exporter un snapshot de l'équipe
squad export

# Diagnostic
squad doctor
```

### Git

```bash
# Créer une feature branch
git checkout -b feature/nom-feature dev

# Push et créer une PR
git push origin feature/nom-feature
gh pr create --base dev

# Synchroniser avec dev
git fetch origin && git rebase origin/dev
```

---

## Workflow Git

```
main ─────────────────────────────────────── (production, déployé automatiquement)
  │
  └── dev ──────────────────────────────────── (intégration)
        │
        ├── feature/hero-section ──┐
        ├── feature/projects-page ─┤── PR → review → merge dev → merge main
        ├── feature/contact-form  ─┘
        │
        └── fix/nav-mobile-menu ──── (hotfix)
```

### Règles

1. **Jamais de push direct sur `main`**
2. Toute feature passe par une PR avec description
3. Les agents Squad travaillent sur des branches dédiées
4. Le build et les tests doivent passer avant tout merge

---

## Roadmap

### v1.0 — MVP (en cours)

- [x] Initialisation du projet (structure, Git, Squad)
- [x] Configuration Squad — chartes des 5 agents (Danny, Rusty, Linus, Livingston, Scribe)
- [x] Page Hero (nom, titre, résumé, CTA)
- [x] Page About (bio, compétences, timeline)
- [x] Page Projects (grille filtrée)
- [x] Page Contact (formulaire)
- [x] Thème Dark/Light
- [x] Responsive design complet (MudBlazor)
- [x] GitHub Actions → déploiement GitHub Pages
- [ ] Vérification build `dotnet build` *(en cours)*
- [ ] Contenu réel (vrais projets, compétences, liens)

### v1.1 — Enrichissement

- [ ] Animations d'entrée (transitions CSS/Blazor)
- [ ] Intégration GitHub API (repos publics live)
- [ ] Page Blog/Articles
- [ ] Tests bUnit complets (>80% coverage)

### v1.2 — Internationalisation

- [ ] Mode multilingue FR/EN
- [ ] Analytics privacy-first (Plausible)
- [ ] Performance audit (Lighthouse >95)

### v2.0 — Template open source

- [ ] Extraction en template réutilisable
- [ ] Documentation pour fork & personnalisation
- [ ] Publication sur NuGet comme template `dotnet new`

---

## Contribuer

Ce projet est principalement personnel mais les retours sont bienvenus.

1. Fork le repository
2. Créer une branche (`feature/votre-amelioration`)
3. Commit avec Conventional Commits
4. Ouvrir une PR avec description détaillée

---

## Licence

MIT — voir [LICENSE](LICENSE)

---

## Auteur

**Aimé WOAGOU**
- Portfolio : *(ce projet)*
- LinkedIn : [linkedin.com/in/votre-profil](https://linkedin.com/in/votre-profil)
- GitHub : [github.com/votre-username](https://github.com/votre-username)

---

> *"Squad amplifie le développeur — il ne le remplace pas. Les agents proposent, l'humain approuve."*
> — Principe fondateur de ce projet
