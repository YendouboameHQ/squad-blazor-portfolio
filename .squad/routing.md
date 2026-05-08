# Routing Rules — Squad Portfolio

## Comment les tâches sont assignées

| Si la tâche concerne... | Agent assigné |
|------------------------|---------------|
| Architecture, décisions techniques, coordination | Lead |
| Composants `.razor`, CSS, layout, design | Frontend |
| Services `.cs`, modèles, logique métier | Backend |
| Tests `*.Tests`, validation, couverture | Tester |
| Documentation `.md`, commentaires, changelog | Scribe |
| Déploiement, CI/CD, GitHub Actions | Lead + Backend |
| Performance, SEO, accessibilité | Frontend + Lead |

## Escalade

Si un agent ne peut pas résoudre un problème seul → escalade au **Lead**.
Si le Lead est bloqué → demande d'input au développeur principal (Aimé).

## Tâches en attente (Backlog initial)

- [ ] [Frontend] Créer `MainLayout.razor` avec navigation sticky
- [ ] [Frontend] Créer `Home.razor` — section Hero
- [ ] [Frontend] Créer `About.razor` — bio + compétences
- [ ] [Frontend] Créer `Projects.razor` — grille filtrée
- [ ] [Frontend] Créer `Contact.razor` — formulaire
- [ ] [Backend] Créer `ProjectModel.cs` et `SkillModel.cs`
- [ ] [Backend] Créer `PortfolioDataService.cs`
- [ ] [Tester] Configurer bUnit dans `tests/`
- [ ] [Tester] Tests unitaires pour `PortfolioDataService`
- [ ] [Frontend] Intégrer MudBlazor + thème Dark/Light
- [ ] [Lead] Configurer GitHub Actions pour déploiement GitHub Pages
- [ ] [Scribe] Maintenir `decisions.md` à jour
