# Vertical Slice Architecture

## Introduction

This document describes the architecture of the Vertical Slice Architecture (VSA) pattern.

## Motivation

In this demo, we will show how to implement the VSA pattern in a simple application.

## VSA History

The VSA pattern was first introduced by Jimmy Bogard in his blog post [Vertical Slice Architecture](https://jimmybogard.com/vertical-slice-architecture/).

![VSA Diagram](./Diagrams/VSA.drawio.png?raw=true)

## VSA Pattern

The VSA pattern is a pattern that structures your application by feature, rather than by layer. This means that all the code related to a feature is in the same place, rather than spread out across different layers.

## Why VSA?

The VSA pattern has several advantages over traditional layered architectures:

- **Simplicity**: The VSA pattern is simpler than traditional layered architectures because it doesn't have as many layers.
- **Flexibility**: The VSA pattern is more flexible than traditional layered architectures because it allows you to change the structure of your application more easily.
- **Testability**: The VSA pattern is more testable than traditional layered architectures because it makes it easier to write tests that only test a single feature.
- **Faster**: The VSA pattern is faster than traditional layered architectures because it allows you to develop features more quickly.
- **Proximity Principle**: The VSA pattern follows the proximity principle, which states that code that changes together should be close together.

## VSA Example

In this demo, we will show how to implement the VSA pattern in a simple application.

The demo will demonstrate how to implement the VSA pattern in a simple application that has the following features:

- **Create a new Todo**: This feature allows the user to create a new todo.
- **Get all Todos**: This feature allows the user to get all todos.
- **Get a Todo by Id**: This feature allows the user to get a todo by its id.
- **Update a Todo**: This feature allows the user to update a todo.
- **Delete a Todo**: This feature allows the user to delete a todo.

## Conclusion

The VSA pattern is a powerful pattern that can help you structure your application in a more flexible, testable way, and faster (less-time).
