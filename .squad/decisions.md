# Decisions Log

> Toutes les décisions architecturales importantes, dans l'ordre chronologique.
> Format : `## [DATE] Titre de la décision`

---

## [2026-05-08] Choix de Blazor WebAssembly

**Contexte :** Choisir entre Blazor Server, Blazor WebAssembly, ou une autre technologie .NET frontend.

**Décision :** Blazor WebAssembly (.NET 8)

**Raisons :**
- Déploiement statique possible (GitHub Pages, Netlify, Azure Static)
- Pas de serveur à maintenir en production
- Réutilisation des compétences .NET existantes
- Performances satisfaisantes pour un portfolio (taille initiale acceptable)

**Alternatives rejetées :**
- Blazor Server : nécessite un serveur SignalR permanent → coût et complexité
- ASP.NET MVC + Razor Pages : moins moderne, pas de composants réactifs
- React/Angular : changement d'écosystème, objectif est de démontrer .NET

**Agent :** Lead

---

## [2026-05-08] Choix de MudBlazor

**Contexte :** Sélection d'une librairie UI pour Blazor.

**Décision :** MudBlazor v6

**Raisons :**
- Composants Material Design riches et bien testés
- Thème Dark/Light natif et simple à configurer
- Compatible Blazor WASM .NET 8
- Communauté active, bonne documentation

**Alternatives rejetées :**
- Bootstrap + CSS custom : plus de travail, moins de composants Blazor-natifs
- Radzen Blazor : licence commerciale pour certains composants
- Telerik UI : payant

**Agent :** Lead + Frontend

---

## [2026-05-08] Hébergement sur GitHub Pages

**Contexte :** Choisir où déployer le portfolio.

**Décision :** GitHub Pages avec GitHub Actions

**Raisons :**
- Gratuit
- CI/CD intégré via Actions
- Domaine custom possible
- Parfait pour un portfolio statique (Blazor WASM = fichiers statiques)

**Alternatives rejetées :**
- Azure Static Web Apps : plus puissant mais complexité inutile pour MVP
- Netlify : viable mais GitHub Pages plus intégré avec le workflow Git

**Agent :** Lead

---

## [2026-05-08] Structure des composants

**Contexte :** Organiser les composants Blazor dans le projet.

**Décision :** `Components/Layout/` + `Components/Pages/`

**Raisons :**
- Séparation claire entre layout (persistant) et pages (contenu)
- Cohérent avec la structure Blazor .NET 8 par défaut
- Facilite la navigation dans le projet

**Agent :** Frontend

---

## [2026-05-08] Utilisation de bUnit pour les tests

**Contexte :** Choisir le framework de tests pour les composants Blazor.

**Décision :** bUnit

**Raisons :**
- Framework officiel recommandé pour les tests Blazor
- Permet de tester les composants `.razor` en isolation
- Bonne intégration avec xUnit

**Agent :** Tester

---

*Ce fichier est maintenu par le Scribe Agent. Toute décision importante doit y être ajoutée.*
