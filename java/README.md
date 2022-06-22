# Java Coding Kata

## Prerequisites

* **Java** (JDK) ≥ 8 (1.8)
  (check with `java -version` / `javac -version`)
* **[Maven](https://maven.apache.org/download.cgi)**
  (check with `mvn --version`)
* some **IDE** (e.g. Eclipse)

## Getting Started

* clone this git repo (you probably already did that)
* `cd java/`
* `mvn package` (this will download JUnit on the first run)

## Running Tests

Either use `mvn test` on the command line, or the test
runner feature of your IDE.

Note that in Eclipse, you probably have to tell it that
this project is using JUnit 5:

* right click on AppTest.java
* Run as
* Run Configurations
* Test runner: JUnit 5

Then you can use "Run As -> JUnit Test" (Alt+Shift+X T).
