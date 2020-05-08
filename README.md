# How to make internal members visible to other assemblies in .net core

To allow internal members in a project to be accessible to a test assembly, simply add the following code block to the csproj file:

```csharp
	<ItemGroup>
		<AssemblyAttribute Include="System.Runtime.CompilerServices.InternalsVisibleTo">
		  <_Parameter1>$(AssemblyName).Tests</_Parameter1>
		</AssemblyAttribute>
	</ItemGroup>
```

Read the full blog post at <a href="https://thecodereaper.com/2020/05/03/how-to-make-internal-members-visible-to-other-assemblies-in-net-core/">theCodeReaper.com</a>

# Three Pillars of a Unit Test

The unit test covered in this repository follows the Three Pillars of a Unit Test guideline. Read the full blog post on Three Pillars of a Unit Test at <a href="https://thecodereaper.com/2020/05/03/three-pillars-of-a-unit-test/">theCodeReaper.com</a>. 
