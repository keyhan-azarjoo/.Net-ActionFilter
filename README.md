# Action Filter Attribute Overview
This repository provides an overview of action filters in ASP.NET Core, focusing on ActionFilterAttribute and IActionFilter. Action filters are essential components for injecting cross-cutting concerns into MVC controllers, such as logging and validation.

# ActionFilterAttribute
ActionFilterAttribute serves as a base class for creating custom action filters. By inheriting from this class, developers can override methods like OnActionExecuting and OnActionExecuted to inject logic before and after the execution of action methods. This approach is ideal for scenarios where filters need to be applied globally or at the controller/action level.

# IActionFilter
IActionFilter is an interface that defines methods to be implemented for action filters. Unlike ActionFilterAttribute, which requires inheritance, IActionFilter allows developers to directly implement interface methods for creating custom filters. This approach offers more flexibility, especially for conditional filter application or scenarios where inheritance is not preferred.

# Getting Started
To explore the usage of ActionFilterAttribute and IActionFilter, clone this repository and review the provided examples. Experiment with creating your own custom action filters to understand how they can enhance the functionality of your ASP.NET Core applications.

# Contributing
Contributions to this repository are welcome! If you have any suggestions, improvements, or bug fixes, feel free to open an issue or submit a pull request.
