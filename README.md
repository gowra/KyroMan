# KyroMan
Simplified .NET library to manage projects

# Specifications
## Project
1. A project have number of tasks.
2. A project has a specified deadline.
3. A project is considered feasible if it can be completed within the specified deadline.

## Task
1. A task requires to be done by an user.
3. A task might require a specific resource or a specific role.
4. A task can depend on other tasks to be completed first.
5. A task takes a definite amount of time to complete.

## Resource
1. A resource can be assigned to a task.
2. Only one task can be alloted with a resource at a time.

## User
1. A user can be assigned to one or more tasks.
2. A user can have a specific role or speciality.