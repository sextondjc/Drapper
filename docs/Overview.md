# Overview

Drapper is a micro-ORM built on another micro-ORM (Dapper) with the principles of _control_ and _performance_ at it's core. It's 
purpose is to allow developers to write a specialised repository layer for their application.

To be more specific, it's a data access / object composition library in that it doesn't really do any object materialization itself 
but rather defers that to Dapper. This leads us to how the name "Drapper" was chosen as it is, essentially, a _wrapper for Dapper_. 
That said, Drapper overcomes a number of limitations of Dapper as well as 
provides a number of features unique to ORM's.

It is not a full-fledged ORM (hence the term "micro-ORM") and there are a number of trade-offs in choosing to use Drapper over other,
more established frameworks. For instance, Drapper has no change-tracking or auto-generated SQL. These were deliberate design decisions.


## Features

The key features of Drapper are _control_ and _performance_. 

Drapper is extremely lightweight (118kb for version 1.1.0) and deliberately uncomplicated. 

### Control 

* You control exactly which SQL is executed, and exactly how it should be executed. 
* SQL is separated from .NET code in an easy to configure format (JSON or XML) allowing you to alter your SQL without recompilation.
* You can target multiple RDBMS systems from within the same class, even within the same method! This is a feature unique to Drapper. 
* Full testability - you can write both unit and integration tests to reach 100% coverage in your application with very little effort.
* Each of the major components of Drapper can be swapped out at will.
* Supports .NET versions 4.5.2, 4.6, 4.6.1 and 4.6.2.

### Performance

Because Drapper is built on top of Dapper, it inherits all of the speed benefits derived from Dapper. Drapper adds very little overhead
to each method call. In some scenarios, Drapper can outperform Dapper in standard benchmark tests. Drapper
easily outperforms Entity Framework, NHibernate, and others. See the Benchmarks section for more details.

## Why Drapper?

You may be wondering why anyone would write "yet-another-ORM" and you'd be write to ask it - I did! I'll start with the name. After many frustrating years of using home-rolled DALs and various ORMs I came across the awesome micro ORM Dapper (if you're new to Dapper, go check it out!). Dapper was what I'd been looking for - no hoop jumping, no disgusting auto-generated SQL, no weird syntax or semantics for simple operations, no lots-of-things-I-hated-about-various-flavoured-ORM.

Dapper is simple, intuitive and targets a variety of different databases without blinking. And on top of all that goodness - it's FAST. Win!

It has, in my humblest of opinions, a drawback. It's a minor one, but one that tainted an otherwise very happy picture - mixing SQL with C# (or whichever .NET language you like most).

I don't like these two languages sharing the same space. It feels messy to me. Kludgy. I'm sure it has some benefits and there's more than one way to keep them separated from each other without going to great lengths. Static class perhaps. List of consts maybe. Resource file, even. Or perhaps something else.

I chose Something Else.

And  thus was born, from a simple desire to separate SQL from C#, a _wrapper for Dapper_ - Drapper.