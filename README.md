# asp-core-mvc-test

This is a test MVC application to demonstrate a .NET Core application running in a Docker container.

# How to build / run

Prerequisites:
* git
* Docker (for desktop)

1. Clone the repository: `git clone https://github.com/Michael-8086/asp-core-mvc-test`
2. Change into the cloned directory: `cd asp-core-mvc-test`
3. Build from the docker file: `docker build -t aspnetapptest .`
4. Run the freshly built container image: `docker run -d -p 8080:80 --name myapp aspnetapptest`