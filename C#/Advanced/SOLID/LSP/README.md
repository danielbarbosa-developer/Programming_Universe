# Liskov Substitution Principle

The LSP is intended to alert us to the use of inheritance and implementation. Basically, derived classes must be substitutable for their base classes.

## This project example

This is an example of design according to LSP. The behavior of the Billing.cs class is not at all using the PersonalLicense.cs or BusinessLicense.cs types. Both are replaced by the interface License.cs 