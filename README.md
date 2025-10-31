# **🚀 Overview**

This project uses the Data-Oriented Tech Stack (DOTS) and the Entity Component System (ECS) architecture in Unity to build high-performance, scalable gameplay systems. It is inspired by the course Unity DOTS Fundamentals – Making a full game with ECS
 by Oliver Carson and the DOTS RTS Course by Code Monkey!

## **🎯 Why use DOTS & ECS?**

Better performance on multicore processors (especially for many entities)

Clear separation of data (components) vs logic (systems)

More scalable architecture for large numbers of objects/entities

Future-proofing: DOTS is the direction Unity has been moving toward

## **💡 Key Features**

Uses Unity’s ECS for entity & component architecture

Uses DOTS Physics for physics simulation (instead of classic GameObject/MonoBehaviour)

Data-oriented design for improved performance

Easily extendable systems for gameplay logic

Codebase structured for clarity and maintainability

## **Systems**

Defined as public partial struct : SystemBase (or IJobEntity jobs) and contain logic operating over all entities with matching component sets. They live in the Systems folder.

## **Authoring**

MonoBehaviour classes that help bridge the GameObject workflow to ECS entities. They live in the Authoring folder.

## **Bootstrap**

Initialization scripts that set up worlds, register systems, configure settings (e.g., for DOTS Physics).
