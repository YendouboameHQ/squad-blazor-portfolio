# PROJECT RECAP — Squad + Blazor Portfolio

> Document de référence du projet. Mis à jour à chaque étape importante.
> **Dernière mise à jour :** 2026-05-08

---

## 1. Contexte & Origine

### Pourquoi ce projet ?

Ce projet est né d'une double intention :
1. **Construire un portfolio personnel** en Blazor .NET pour démontrer des compétences techniques
2. **Explorer et documenter Squad** — un framework d'orchestration d'agents IA basé sur GitHub Copilot — en l'utilisant comme équipe de développement active

L'idée centrale : montrer concrètement comment des agents IA spécialisés (Lead, Frontend, Backend, Tester, Scribe) peuvent collaborer sur un projet réel, avec un humain aux commandes des décisions.

### Source d'inspiration

- **Squad** : [github.com/bradygaster/squad](https://github.com/bradygaster/squad/tree/dev) — outil open source de Brady Gaster
- **Modèle Spotify Squad** : organisation en équipes autonomes cross-fonctionnelles
- **Objectif LinkedIn** : partager ce retour d'expérience avec la communauté tech

---

## 2. Objectifs du Projet

| Priorité | Objectif |
|----------|----------|
| 🥇 | Démontrer l'utilisation de Squad dans un contexte réel |
| 🥇 | Construire un portfolio Blazor .NET fonctionnel et déployable |
| 🥈 | Documenter le processus agent-par-agent |
| 🥈 | Produire un retour d'expérience LinkedIn concret et crédible |
| 🥉 | Créer une base réutilisable (template) pour d'autres projets Blazor + Squad |

---

## 3. Ce Qu'on a Défini

### 3.1 Stack technique

| Composant | Technologie | Raison |
|-----------|-------------|--------|
| Framework UI | Blazor WebAssembly (.NET 8) | C# full-stack, déployable statiquement |
| UI Components | MudBlazor | Matière Design, riche, compatible WASM |
| Orchestration IA | Squad (`@bradygaster/squad-cli`) | Framework ciblé, agents spécialisés |
| IA Engine | GitHub Copilot | Requis par Squad |
| Hébergement | GitHub Pages / Azure Static Web Apps | Gratuit, CI/CD simple |
| Tests | bUnit | Framework de test Blazor officiel |
| Versionning | Git + GitHub | Standard industrie |

### 3.2 Architecture Squad

```
.squad/
├── team.md              # Composition de l'équipe
├── routing.md           # Règles de dispatch des tâches
├── decisions.md         # Log de toutes les décisions prises
├── agents/
│   ├── lead/            # Chef d'équipe — coordination, architecture
│   │   ├── charter.md
│   │   └── history.md
│   ├── frontend/        # Interface Blazor, composants, CSS
│   │   ├── charter.md
│   │   └── history.md
│   ├── backend/         # Services, modèles, logique métier
│   │   ├── charter.md
│   │   └── history.md
│   ├── tester/          # Tests bUnit, validation
│   │   ├── charter.md
│   │   └── history.md
│   └── scribe/          # Documentation, décisions, README
│       ├── charter.md
│       └── history.md
├── skills/              # Connaissances partagées entre agents
└── log/                 # Logs de session
```

### 3.3 Architecture du Portfolio

```
src/SquadPortfolio/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   └── Pages/
│       ├── Home.razor           # Hero + résumé
│       ├── About.razor          # Profil + compétences
│       ├── Projects.razor       # Grille de projets
│       ├── Contact.razor        # Formulaire de contact
│       └── Error.razor
├── Models/
│   ├── ProjectModel.cs          # Modèle projet
│   └── SkillModel.cs            # Modèle compétence
├── Services/
│   └── PortfolioDataService.cs  # Source de données
├── wwwroot/
│   ├── css/
│   └── index.html
├── App.razor
├── Program.cs
└── SquadPortfolio.csproj
```

---

## 4. Fonctionnalités Prévues

### MVP (v1.0)

- [ ] **Page Hero** — Nom, titre, résumé accrocheur, CTA
- [ ] **Page About** — Bio, compétences, timeline expérience
- [ ] **Page Projects** — Grille de cartes avec filtre par technologie
- [ ] **Page Contact** — Formulaire statique (mailto ou EmailJS)
- [ ] **Thème Dark/Light** — Toggle persisté en localStorage
- [ ] **Responsive** — Mobile, tablette, desktop
- [ ] **Navigation** — Menu sticky avec liens d'ancrage
- [ ] **Déploiement** — GitHub Actions → GitHub Pages

### v1.1 (après MVP)

- [ ] Animations d'entrée (AOS ou Blazor transitions)
- [ ] Page Blog/Articles
- [ ] Intégration GitHub API (repos publics live)
- [ ] Mode multilingue (FR/EN)
- [ ] Analytics (Plausible ou Umami — privacy-first)

---

## 5. Décisions Importantes

| Date | Décision | Raison |
|------|----------|--------|
| 2026-05-08 | Blazor WebAssembly (pas Server) | Déploiement statique, pas de serveur à maintenir |
| 2026-05-08 | MudBlazor (pas Bootstrap) | Maturité, composants riches, compatibilité .NET 8 |
| 2026-05-08 | GitHub Pages pour l'hébergement initial | Gratuit, CI/CD via Actions, parfait pour un portfolio |
| 2026-05-08 | Squad installé en global npm | Cohérent avec les docs officielles |
| 2026-05-08 | Un agent = une responsabilité claire | Éviter les conflits, traçabilité des décisions |
| 2026-05-08 | `.squad/` commité dans Git | Mémoire d'équipe persistante entre sessions |

---

## 6. Comment Squad est Utilisé

### Workflow de développement

```
Humain (Aimé) → définit les objectifs et priorités
     ↓
Lead Agent → analyse, découpe en tâches, assigne
     ↓
Frontend Agent → composants Blazor, CSS, layout
Backend Agent → services, modèles, logique
Tester Agent → tests bUnit, validation
Scribe Agent → documentation, décisions.md
     ↓
Humain → review, approbation, merge
```

### Règle fondamentale

> **Squad amplifie le développeur — il ne le remplace pas.**
> Chaque décision finale appartient à l'humain.
> Les agents proposent, l'humain approuve.

### Commandes Squad utilisées

```bash
npm install -g @bradygaster/squad-cli   # Installation
squad init                              # Initialisation dans le projet
squad status                            # État de l'équipe
squad triage                            # Analyse des tâches en attente
squad watch                             # Mode surveillance automatique
squad doctor                            # Diagnostic
```

---

## 7. Prochaines Étapes

### Immédiat (Session actuelle)

1. [x] Créer le repository GitHub `squad-blazor-portfolio`
2. [x] Structurer le projet (répertoires, fichiers de base)
3. [x] Configurer Squad (`.squad/` avec chartes d'agents)
4. [ ] Installer .NET SDK si absent, créer le projet Blazor WASM
5. [ ] Exécuter `squad init` et configurer l'équipe
6. [ ] Faire construire la première page (Hero) par le Frontend Agent
7. [ ] Documenter le premier cycle de travail Squad

### Court terme (v1.0)

1. [ ] Compléter les 4 pages principales
2. [ ] Intégrer MudBlazor
3. [ ] Configurer GitHub Actions pour le déploiement
4. [ ] Déployer sur GitHub Pages
5. [ ] Publier le post LinkedIn avec lien vers le repo

### Moyen terme (v1.1+)

1. [ ] Enrichir le contenu avec les vrais projets
2. [ ] Ajouter les animations
3. [ ] Explorer l'intégration GitHub API via Backend Agent
4. [ ] Écrire un article technique détaillé (Medium ou dev.to)

---

## 8. Liens Utiles

| Ressource | URL |
|-----------|-----|
| Repo Squad (source) | https://github.com/bradygaster/squad/tree/dev |
| Blazor WASM docs | https://learn.microsoft.com/blazor |
| MudBlazor | https://mudblazor.com |
| bUnit (tests) | https://bunit.dev |
| GitHub Pages | https://pages.github.com |

---

*Ce fichier est maintenu par le Scribe Agent et mis à jour manuellement à chaque étape clé.*
