# Chapter 3 - Exercise 1

## Objectives

TODO: add objectives

## Exercise

* Create the following folder structure
  * ch-3-exercise-3
    * src
* Use a dotnet command to create a new solution in the `src` folder called `BlackJack`
* Use a dotnet command to create a `.gitignore` file in the root folder `ch-3-exercise-3`
* Use a `git` command to make the root folder `ch-3-exercise-3` a GIT repository
* Use a `git` command or Visual Studio to commit your changes
  * Make sure there are no binary files tracked in the repository.

## Solution

* Create the following folder structure
  * ch-3-exercise-3
    * src
* Use a dotnet command to create a new solution in the `src` folder called `BlackJack`

```{console}
cd src
dotnet new sln -n BlackJack
```

* Use a dotnet command to create a `.gitignore` file in the root folder `ch-3-exercise-3`

```{console}
cd ..
dotnet new gitignore
```

* Use a `git` command to make the root folder `ch-3-exercise-3` a GIT repository

```{console}
git init
```

* Use a `git` command or Visual Studio to commit your changes
  * Make sure there are no binary files tracked in the repository.

```{console}
git add .
git commit -m "Create solution"
```
