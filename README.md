# Plugin System Example

This project demonstrates how to use reflection in C# to create a flexible plugin system. The main program dynamically loads and executes plugins without needing to be recompiled when new plugins are added.

## Project Structure

- **Plugins/**: Contains the plugin interface and sample plugins.
  - `IPlugin.cs`: The common interface that all plugins implement.
  - `MathPlugin.cs`: A plugin that performs a simple math operation.
  - `StringPlugin.cs`: A plugin that manipulates a string (reverses it).

- **MainProgram/**: Contains the main program that loads and executes the plugins using reflection.
  - `Program.cs`: The entry point of the application.

## How It Works

1. The `IPlugin` interface defines a contract that all plugins must follow, with a `Name` and an `Execute` method.

2. Each plugin (e.g., `MathPlugin` and `StringPlugin`) implements the `IPlugin` interface.

3. The main program uses reflection to:
   - Dynamically load the `Plugins.dll` assembly.
   - Discover all types that implement the `IPlugin` interface.
   - Create instances of these types.
   - Execute the `Execute` method of each plugin.

## Running the Example

1. Build the project, ensuring that the `Plugins` and `MainProgram` projects compile into separate assemblies (DLLs).

2. Run the main program (`MainProgram.exe`). It will:
   - Load the `Plugins.dll` assembly.
   - Discover and execute all plugins.

You should see output like this:

Executing Math Plugin
[MathPlugin] 5 + 10 = 15
------------------------
Executing String Plugin
[StringPlugin] Reversed string : dneirF ,olleH
------------------------


## Adding New Plugins

To add a new plugin:

1. Create a new class that implements the `IPlugin` interface.
2. Compile it into the `Plugins.dll` assembly.
3. Run the main program again, and it will automatically discover and execute the new plugin.

## Benefits of Using Reflection

- **Extensibility**: New plugins can be added without modifying the main program.
- **Flexibility**: The main program doesn't need to know the details of the plugins; it just loads and executes them dynamically.

## Considerations

- **Performance**: Reflection is slower than direct method calls, so it's important to balance flexibility with performance requirements.
- **Security**: Be cautious with reflection, especially when loading assemblies from untrusted sources.
