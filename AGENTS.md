# AGENTS.md - AI Coding Agent Guidelines

These guidelines are designed to ensure efficient, maintainable, and robust development for the AGENTS repository. Adherence to these principles is crucial for producing high-quality AI coding agents.

## 1. DRY (Don't Repeat Yourself)

*   **Single Responsibility Principle:** Each agent module should have a single, well-defined purpose.  Avoid creating overly complex modules with multiple responsibilities.
*   **Code Reuse:**  Whenever possible, leverage existing components and libraries to reduce duplication.  Document reusable functions and classes clearly.
*   **Abstraction:** Create abstract classes or interfaces to represent common functionalities, allowing for easy substitution and reuse.

## 2. KISS (Keep It Simple, Stupid)

*   **Minimal Code:** Strive for the shortest possible solution that fulfills the required functionality. Avoid unnecessary complexity.
*   **Readability:** Prioritize code clarity and maintainability. Use meaningful variable and function names.
*   **Simplicity:**  Keep design choices and algorithms straightforward.  Avoid convoluted logic.

## 3. SOLID Principles

*   **Single Responsibility Principle:** As mentioned above, each class/module should have a single responsibility.
*   **Open/Closed Principle:**  New functionality should be added through extensions or interfaces, without modifying existing code.
*   **Liskov Substitution Principle:**  Subclasses should be able to replace a base class without affecting the correctness of the program.
*   **Interface Segregation Principle:** Clients shouldn’t be forced to depend on methods they don’t use.
*   **Dependency Inversion Principle:**  High-level modules should not depend on low-level modules.  They should depend on abstractions.

## 4. YAGNI (You Aren't Gonna Need It)

*   **Avoid Unnecessary Features:** Do not implement functionality that is not currently required. Focus on delivering the minimum viable implementation.
*   **Future-Proofing:**  Avoid premature implementation of features that might be obsolete.

## 5. File Size & Code Quality

*   **Maximum Code Length:** Each file must have a maximum of 180 lines of code.
*   **Comments:**  Write clear and concise comments explaining the *why* behind the code, not just the *what*.
*   **Error Handling:**  Implement appropriate error handling to prevent unexpected crashes.  Log errors appropriately.
*   **Testing:** All code must be thoroughly tested.

## 6. Testing - Focus on Unit Tests

*   **Unit Tests Only:** All development must be guided by unit tests. No mocks or fake implementations are allowed.
*   **Comprehensive Tests:** Write tests for all critical functions and modules.  Aim for 80% test coverage.
*   **Test-Driven Development:**  Focus on writing tests *before* writing code.
*   **Test Isolation:** Tests should be isolated and easily repeatable.

## 7. Development Workflow

*   **Version Control:** Use Git for version control. Commit frequently with clear commit messages.
*   **Code Reviews:** Conduct regular code reviews to identify potential issues and ensure code quality.
*   **Documentation:**  Maintain clear and concise documentation for all modules and functions.

## 8.  Specific Considerations for AGENTS.md

*   **Data Structures:** Define clear and consistent data structures for representing agents, data, and interactions.
*   **Event Handling:**  Implement a robust event handling mechanism to manage agent communication.
*   **Agent States:**  Define a well-defined state machine for representing agent states.
*   **API Design:** Design well-documented and consistent APIs for accessing agent functionalities.


These guidelines are subject to change as the AGENTS repository evolves.  Regular review and updates are necessary to maintain a high-quality codebase.