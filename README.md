NUnitWithInheritanceDemo
========================

This demonstrate how to use NUnit with Inheritance.

This is the output of the code

    Base class - Setup - Once per class
    	Implementation - Setup - Once per class
    		Implementation - Setup - once per test
    			Test1
    		Implementation - Teardown - once per test
    		Implementation - Setup - once per test
    			Test2
    		Implementation - Teardown - once per test
    	Implementation - Teardown - Once per class
    Base class - Teardown - Once per class
