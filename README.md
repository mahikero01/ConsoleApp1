#Variables
- FCL         VB
- Int32      Integer
- Int64      Long
- Boolean    Boolean
- Single      Single
- Double     Double
- Decimal    Decimal
- DateTime   Date
- String     String


#Operator
- Mathematical (+, -, *, /,\, Mod)
- Relational (<, >, <=, >=)
- Equality (==, <>)
- Conditional (And, Or, AndAlso, OrElse)
- Assignment (=, +=, -=, *=, /=)
- String Concatenate (&)


#Array
- Dim suits(3) As String
months(0) = "Clubs"
months(1) = "Diamonds"
months(2) = "Hearts"
months(3) = "Spades"

- Dim numbers() As Integer = {40, 50, 60, 70}

- Dim grid = {{1,2},{3,4}}


#Enum
- Public Enum Suit
	Clubs = 1
	Diamonds = 3
	Hearts = 6
	Spades = 9
End Num


#If 
- If conditionStatement Then
	'...
End If

- If conditionStatement Then
	'...
Else
	'...
End If

- If conditionStatement Then
	'...
ElseIf
	'...
Else
	'...
End If


#Case
- Select Case code
	Case 1
		'...
	Case Is < 10
		'...
	Case 11,33,14
		'...
	Case Else
		'...
End Select


#For
- For i = 1 To max
	'...
Next

- For i = max To 1 Step -1
	'...
Next

- Exit For   ---  exit loop
- Continue   ---  skip to the next iteration

#while
- While index <= 10
	index += 1
	'...
End While


#For Each
- For Each age As Integer In ages
	'...
Next


#Procedure
- Sub FunctionName(ByVal value As String, ByRef value2 As String)
	'...
End Sub

- Sub FunctionName(ByRef value2 As String)
	'...
End Sub

- Function FunctionName (ByVal val As Integer) As Integer
	'...
End Function


#Exception
- Try
	'...
Catch ex1 As DivideByZeroException
	'...
Catch ex2 As ArithmeticException
	'...
Catch ex3 As Exception
	'...
Finally
	'...
End Try

- Sub ThrowingEx()
	Throw New ArgumentException()
End Sub


#Class
- Public Class ClassName
	'...
End Class


#Fields
- Class Employee
	Public Name As String
	Public Salary As Boolean
	Private _birthDate As DateTime
End  Class


#Properties
- Class Employee
	Private _name As String
	Private _birthDate As DateTime
	Public Property Department As String
	
	Public Property Name As String
		Get
			return _name
		End Get
		Set
			If Not String.IsNullOrEmpty(value) Then
				_name = value
			End If
		End Set
	End Property
	
	Public ReadOnly Property Age As Integer
		Get
			Dim diff = DateTime.Now - _birthDate
			Return diff.Days \ 365
		End Get
	End Property
End Class


#Method
- Public Class ClassName
	Public Function GetDesc()
		'...
	End Function 
End Class


#Constructor
- Class Employee
	Public Sub New()
		'...
	End Sub
	
	Public Sub New(ByVal name As String)
		'...
	End Sub
End Class


#Conversion
- Convert.ToInt32()
- Convert.ToBoolean()
- Convert.ToDouble()

- Integer.Parse()
- Boolean.Parse()
- Double.Parse()


#Inheritance
- Class Shape
	'...
	Pubic Shared Property Diameter As Double 'static equivalent
End Class

- Class Square
	Inherits Shape
End Class

- Class Circle
	Inherits Shape
End Class


#Abstract
- Public MustInherit Class Shape
	Public MustOverride Function Area() As Integer
End Class

- Public Class Square : Inherits Shape
	Public Ovverrides Function Area() As Integer
		'...
	End Function
End Class


#Virtual Members
- Protected Overridable Sub SetColors()
	'...
End Sub

- Protected Overrides Sub SetColors()
	'...
	'...
End Sub


#Derived Constructor
- Class Shape
	Public Sub New()
		'...
	End Sub
End Class

- Class Rectangle : Inherits Shape
	Public Sub New()
		MyBase.New() ' call base constructor
	End Sub
End Class


#Interface
- Interface IXmlExport
	Function GetXml() As String
End Interface

- Class Shape Implements IXmlExport
	Public Function GetXml() As String _
		Implements IXmlExport.GetXml
		'...
	End Function
End Class


#StringBuilder
- Dim str as New StringBuilder

- str.Append("abcdef")  'add string at the end
- str.Length  'return length of string e.g. 6
- str.Chars(int32) or str(int32)  'get/set specifie character in the instance
- str.AppendLine()    'insert next line
- str.AppendLine(string)  'insert string at the end then next line
- str.Clear()       'clear content 
- str.Equals(Object)    'return true if the object is the same with the instance
- str.Insert(int32, string)   'Inserts a string into this instance at the specified character position
- str.Remove(int32, int32)    'Removes the specified range of characters from this instance
- str.Replace(String, String)   'Replaces all occurrences of a specified string in this instance with another specified string


#List
- Dim squares as New List(Of Square)
- 'Dim squares as New ArrayList()

- For Each square In squares
	'...
Next

- squares.Capacity  'set/get capacity
- squares.Count   'get/set  number of element
- squares.Item(Int32) or squares(Int32)  'get/set the element at the specified index
- squares.Add(Object)  'Adds an object to the end of the List(Of T)
- squares.Clear()       'Removes all elements from the List(Of T)
- squares.Contains(T)  'Determines whether an element is in the List(Of T)
- squares.Equals(Object)   'Determines whether the specified object is equal to the current object.(Inherited from Object.)
- squares.IndexOf(T)		'Searches for the specified object and returns the zero-based index of the first occurrence within the entire List(Of T)
- squares.Insert(Int32, T)  'Inserts an element into the List(Of T) at the specified index
- squares.LastIndexOf(T)     'Searches for the specified object and returns the zero-based index of the last occurrence within the entire List(Of T)
- squares.Remove(T)      'Removes the first occurrence of a specific object from the List(Of T)
- squares.RemoveAt(Int32)     'Removes the element at the specified index of the List(Of T)
- squares.Reverse()           'Reverses the order of the elements in the entire List(Of T)
- squares.Sort()       'Sorts the elements in the entire List(Of T) using the default comparer.
- squares.ToArray()      'Copies the elements of the List(Of T) to a new array.


#Dictionary
- Dim squares As New Dictionary(Of Integer, Square)
- 'Dim squares As New Hashtable()

- squares.Add(4, SquareObject)


#LINQ
- Dim query = From emp In employees
			Where emp.Salaried AndAlso emp.Age > 35
			Order By emp.Name
			Select emp

			
#Lambda
- Dim query = employees.Where( Function(e) e.Salaried AndAlso e.Age > 35 )
