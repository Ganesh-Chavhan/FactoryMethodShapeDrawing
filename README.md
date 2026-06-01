# Factory Method Shape Drawing System in C#

## Overview

This project demonstrates the implementation of the **Factory Method Design Pattern** in C# using a simple **Shape Drawing System**.

The application creates different shape objects such as Circle, Rectangle, and Triangle through dedicated factory classes instead of directly instantiating them in the client code. This approach promotes loose coupling, scalability, and maintainability.

---

## Design Pattern Used

### Factory Method Pattern

The Factory Method is a **Creational Design Pattern** that provides an interface for creating objects while allowing subclasses to decide which specific object to create.

Instead of using direct object creation (`new` keyword) throughout the application, object creation is delegated to factory classes.

---

## Project Objective

The main objectives of this project are:

- Understand the Factory Method Design Pattern
- Separate object creation from business logic
- Achieve loose coupling between client code and concrete classes
- Improve code maintainability and scalability
- Demonstrate object-oriented design principles

---

## Project Structure

```text
FactoryMethodShapeDrawing
│
├── IShape.cs
├── Circle.cs
├── Rectangle.cs
├── Triangle.cs
│
├── ShapeFactory.cs
├── CircleFactory.cs
├── RectangleFactory.cs
├── TriangleFactory.cs
│
└── Program.cs
