# SCTAPITests

## Project Overview

The SCTAPITests project is designed to test an API by reading the API endpoint from the `appsettings.json` file. The endpoint is then utilized by the `TestSetup` class to send a GET request, and the resulting response is consumed by the `Tests` class for validation.

## Components

### 1. TestSetup Class

The `TestSetup` class plays a crucial role in the testing process. It reads the API endpoint from the `appsettings.json` file using the `IConfiguration` interface. The class utilizes this endpoint to make a GET request, fetching the response for further processing.

### 2. Tests Class

The `Tests` class is responsible for validating three specific tests using the API response obtained through the `TestSetup` class.

### 3. Models Folder

The `Models` folder contains two constructors created for the project. These constructors are integral to the testing process, facilitating the creation of necessary objects and structures.

## Usage

1. Ensure that the `appsettings.json` file is correctly configured with the desired API endpoint.

2. Run the tests using the appropriate test runner, allowing the `TestSetup` and `Tests` classes to validate the API based on the configured endpoint.

This project aims to streamline API testing, providing a clear structure for retrieving and validating responses through the specified endpoint.