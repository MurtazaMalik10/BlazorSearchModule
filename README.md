# Static Blazor Website

## Overview

This project is a static website built using [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) and C#. It provides a user-friendly interface for browsing and filtering tours. Users can search for tours based on location, date, and price range, and apply various filters to refine the search results.

## Features

- **Home Page**: Includes a search bar for finding tours based on location, date, and price range.
- **Tours Page**: Displays a list of tours with options to filter by services, viewpoints, and duration.
- **Filter Options**: Allows users to apply filters to refine the list of tours.

## Prerequisites

To run this project, you need to have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (for Blazor development)
- A compatible web browser (e.g., Google Chrome, Mozilla Firefox)

## Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/MurtazaMalik10/BlazorSearchModule.git
   
2. **Navigate to the Project Directory**

    ```bash
   cd BlazorSearchModule

3. **Restore Dependencies**

    ```bash
   dotnet restore

   
## Project Structure

- **`Pages/Index.razor`**: The home page with the search functionality.
- **`Pages/Tours.razor`**: Displays the list of tours and handles filtering.
- **`Shared/FilterSidebar.razor`**: A component for applying filters on the tours page.
- **`wwwroot/`**: Contains static files such as CSS, JavaScript, and images.

## Code Overview

### `Index.razor`

Handles the search functionality, including location, date, and price range. Redirects to the `Tours` page with search parameters.

### `Tours.razor`

Displays the list of tours and handles filtering based on the selected criteria.

### `FilterSidebar.razor`

Provides filtering options for services, viewpoints, and duration.

## Contributing

If you would like to contribute to this project, please follow these steps:

1. **Fork the repository.**
2. **Create a new branch for your changes.**
3. **Commit your changes and push them to your fork.**
4. **Submit a pull request with a description of the changes.**


## License

This project is licensed under the [MIT License](LICENSE).

Feel free to adjust any sections to better fit your project or add any additional information as needed.
