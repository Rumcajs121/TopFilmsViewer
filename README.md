# 🏆 TopFilmsViewer

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Blazor](https://img.shields.io/badge/Blazor-WebAssembly-orange.svg)](https://blazor.net/)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-blue.svg)](https://docs.microsoft.com/en-us/ef/)

> Projekt aplikacji webowej do przeglądania top filmów, zbudowany z wykorzystaniem Blazor WebAssembly i Server, z architekturą Clean Architecture. Aplikacja pozwala na wyświetlanie listy filmów wraz z ich gatunkami, studiami i zdjęciami. Projekt jest w trakcie rozwoju i może zawierać niedokończone funkcjonalności.

## 📋 Spis treści
- [Opis projektu](#opis-projektu)
- [Technologie](#technologie)
- [Architektura](#architektura)
- [Funkcjonalności](#funkcjonalności)
- [Status projektu](#status-projektu)
- [Autor](#autor)

## 📖 Opis projektu
Celem tego projektu jest stworzenie aplikacji webowej umożliwiającej przeglądanie i zarządzanie informacjami o filmach. Aplikacja wykorzystuje nowoczesne technologie webowe, takie jak Blazor, aby zapewnić interaktywny interfejs użytkownika. Projekt został zrealizowany z wykorzystaniem architektury Clean Architecture, co zapewnia modularność i łatwość utrzymania kodu.

Projekt jest częścią portfolio deweloperskiego i demonstruje umiejętności w zakresie tworzenia aplikacji ASP.NET Core z wykorzystaniem Blazor.

## 🏗 Architektura

Projekt został zbudowany zgodnie z zasadami Clean Architecture:

### ApplicationLayer
- **Interfejsy usług aplikacji** - definiuje kontrakty dla logiki biznesowej
- **DTOs** - obiekty transferu danych między warstwami

### DomainLayer
- **Encje biznesowe** - klasy reprezentujące domenę problemu (Film, Gatunek, Studio, Zdjęcie)
- **Reguły biznesowe** - logika specyficzna dla domeny

### InfrastructureLayer
- **Repozytoria** - implementacja dostępu do danych z wykorzystaniem Entity Framework Core
- **Kontekst bazy danych** - konfiguracja EF Core dla SQL Server
- **Migracje** - zarządzanie schematem bazy danych

### Presentation Layer (TopFilmsViewer)
- **Blazor Server** - część serwerowa aplikacji
- **Blazor WebAssembly** - część kliencka aplikacji
- **Komponenty Razor** - interfejs użytkownika

## 🛠 Technologie

### Backend
- **ASP.NET Core 8.0** - framework do budowy aplikacji webowych
- **Blazor** - framework do budowy interaktywnych aplikacji webowych
- **Entity Framework Core** - ORM dla dostępu do bazy danych
- **AutoMapper** - biblioteka do mapowania obiektów
- **SQL Server** - system zarządzania bazą danych

### Frontend
- **Blazor WebAssembly** - aplikacja kliencka działająca w przeglądarce
- **Bootstrap** - framework CSS do responsywnego designu
- **HTML5 & CSS3** - języki znaczników i stylów

### Narzędzia deweloperskie
- **Visual Studio 2022** - środowisko programistyczne
- **Git** - system kontroli wersji

## ✨ Funkcjonalności
- ✅ Wyświetlanie listy wszystkich filmów
- ✅ Wyświetlanie szczegółowych informacji o filmie (tytuł, gatunki, studio)
- ✅ Przeglądanie zdjęć powiązanych z filmami
- 🔄 Dodawanie nowych zdjęć do filmów (w trakcie implementacji)
- 🔄 Zarządzanie filmami (CRUD) (planowane)
- 🔄 Filtrowanie i wyszukiwanie filmów (planowane)

## 📊 Status projektu
⚠️ Projekt w trakcie rozwoju - Nie wszystkie funkcjonalności są jeszcze zaimplementowane. Aktualnie dostępne:

## 👨‍💻 Autor
**Rumcajs121** - Student Informatyki, Społeczna Akademia Nauk w Łodzi

