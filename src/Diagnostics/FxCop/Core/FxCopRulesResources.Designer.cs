﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.FxCopAnalyzers {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class FxCopRulesResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FxCopRulesResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.FxCopAnalyzers.FxCopRulesResources", typeof(FxCopRulesResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Abstract classes should not have public constructors.
        /// </summary>
        internal static string AbstractTypesShouldNotHavePublicConstructors {
            get {
                return ResourceManager.GetString("AbstractTypesShouldNotHavePublicConstructors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change the accessibility of all public contructors in this class to protected..
        /// </summary>
        internal static string AbstractTypesShouldNotHavePublicConstructorsCodeFix {
            get {
                return ResourceManager.GetString("AbstractTypesShouldNotHavePublicConstructorsCodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add [Serializable] to {0} as this type implements ISerializable.
        /// </summary>
        internal static string AddSerializableAttributeToType {
            get {
                return ResourceManager.GetString("AddSerializableAttributeToType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assemblies should be marked with AssemblyVersionAttribute.
        /// </summary>
        internal static string AssembliesShouldBeMarkedWithAssemblyVersionAttribute {
            get {
                return ResourceManager.GetString("AssembliesShouldBeMarkedWithAssemblyVersionAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid unsealed attributes..
        /// </summary>
        internal static string AvoidUnsealedAttributes {
            get {
                return ResourceManager.GetString("AvoidUnsealedAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consider changing the ComVisible attribute on {0} to false, and opting in at the type level..
        /// </summary>
        internal static string CA1017_AttributeTrue {
            get {
                return ResourceManager.GetString("CA1017_AttributeTrue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Because {0} exposes externally visible types, mark it with ComVisible(false) at the assembly level and then mark all types within the assembly that should be exposed to COM clients with ComVisible(true)..
        /// </summary>
        internal static string CA1017_NoAttribute {
            get {
                return ResourceManager.GetString("CA1017_NoAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Design.
        /// </summary>
        internal static string CategoryDesign {
            get {
                return ResourceManager.GetString("CategoryDesign", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Globalization.
        /// </summary>
        internal static string CategoryGlobalization {
            get {
                return ResourceManager.GetString("CategoryGlobalization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interoperability.
        /// </summary>
        internal static string CategoryInteroperability {
            get {
                return ResourceManager.GetString("CategoryInteroperability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Naming.
        /// </summary>
        internal static string CategoryNaming {
            get {
                return ResourceManager.GetString("CategoryNaming", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performance.
        /// </summary>
        internal static string CategoryPerformance {
            get {
                return ResourceManager.GetString("CategoryPerformance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reliability.
        /// </summary>
        internal static string CategoryReliability {
            get {
                return ResourceManager.GetString("CategoryReliability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage.
        /// </summary>
        internal static string CategoryUsage {
            get {
                return ResourceManager.GetString("CategoryUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change &apos;{0}&apos; to a property if appropriate..
        /// </summary>
        internal static string ChangeToAPropertyIfAppropriate {
            get {
                return ResourceManager.GetString("ChangeToAPropertyIfAppropriate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disposable fields should be disposed.
        /// </summary>
        internal static string DisposableFieldsShouldBeDisposed {
            get {
                return ResourceManager.GetString("DisposableFieldsShouldBeDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not call overridable methods in constructors.
        /// </summary>
        internal static string DoNotCallOverridableMethodsInConstructors {
            get {
                return ResourceManager.GetString("DoNotCallOverridableMethodsInConstructors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual methods defined on the class should not be called from constructors. If a derived class has overridden the method, the derived class version will be called (before the derived class constructor is called)..
        /// </summary>
        internal static string DoNotCallOverridableMethodsInConstructorsDescription {
            get {
                return ResourceManager.GetString("DoNotCallOverridableMethodsInConstructorsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not lock on objects with weak identity..
        /// </summary>
        internal static string DoNotLockOnObjectsWithWeakIdentity {
            get {
                return ResourceManager.GetString("DoNotLockOnObjectsWithWeakIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not lock on a reference of type &apos;{0}&apos; as it has weak identity. Replace that with a lock against an object with strong identity..
        /// </summary>
        internal static string DoNotLockOnWeakIdentity {
            get {
                return ResourceManager.GetString("DoNotLockOnWeakIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not mark Enum with FlagsAttribute.
        /// </summary>
        internal static string DoNotMarkEnumsWithFlags {
            get {
                return ResourceManager.GetString("DoNotMarkEnumsWithFlags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The enumeration does not appear to contain a consistent set values that can be combined using  the OR (|) and AND (&amp;amp;amp;amp;) operators. Using the Flags attribute on an enumeration suggests that the enumeration values are meant to be combined using the AND and OR operators. Typically, a flags enumeration uses values that are either powers of two, or combine other values that are powers of two..
        /// </summary>
        internal static string DoNotMarkEnumsWithFlagsDescription {
            get {
                return ResourceManager.GetString("DoNotMarkEnumsWithFlagsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is marked with FlagsAttribute but a discrete member cannot be found for every settable bit that is used across the range of enum values. Remove FlagsAttribute from the type or define new members for the following (currently missing) values: &apos;{1}&apos;..
        /// </summary>
        internal static string DoNotMarkEnumsWithFlagsMessage {
            get {
                return ResourceManager.GetString("DoNotMarkEnumsWithFlagsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enums should have zero value..
        /// </summary>
        internal static string EnumsShouldHaveZeroValue {
            get {
                return ResourceManager.GetString("EnumsShouldHaveZeroValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An enum should generally have a zero value. If the enum is not decorated with the Flags attribute, it should have a member with a value of zero that represents the empty state. Optionally, this value is named &apos;None&apos;. For a Flags-attributed enum, a zero-valued member is optional and, if it exists, should always be named &apos;None&apos;. This value should indicate that no values have been set in the enum. Using a zero-valued member for other purposes is contrary to the use of the Flags attribute in that the bitwise AN [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EnumsShouldHaveZeroValueDescription {
            get {
                return ResourceManager.GetString("EnumsShouldHaveZeroValueDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all members that have the value zero from &apos;{0}&apos; except for one member that is named &apos;None&apos;..
        /// </summary>
        internal static string EnumsShouldZeroValueFlagsMultipleZero {
            get {
                return ResourceManager.GetString("EnumsShouldZeroValueFlagsMultipleZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In enum &apos;{0}&apos;, change the name of &apos;{1}&apos; to &apos;None&apos;..
        /// </summary>
        internal static string EnumsShouldZeroValueFlagsRename {
            get {
                return ResourceManager.GetString("EnumsShouldZeroValueFlagsRename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add a member to &apos;{0}&apos; that has a value of zero with a suggested name of &apos;None&apos;..
        /// </summary>
        internal static string EnumsShouldZeroValueNotFlagsNoZeroValue {
            get {
                return ResourceManager.GetString("EnumsShouldZeroValueNotFlagsNoZeroValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field {0} is a member of type {1} which is serializable but is of type {2} which is not serializable.
        /// </summary>
        internal static string FieldIsOfNonSerializableType {
            get {
                return ResourceManager.GetString("FieldIsOfNonSerializableType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} &apos;{1}&apos; have identical names in a case-insensitive manner..
        /// </summary>
        internal static string IdentifierNamesShouldDifferMoreThanCase {
            get {
                return ResourceManager.GetString("IdentifierNamesShouldDifferMoreThanCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identifier names should differ by more than case.
        /// </summary>
        internal static string IdentifiersShouldDifferByMoreThanCase {
            get {
                return ResourceManager.GetString("IdentifiersShouldDifferByMoreThanCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use names that require case sensitivity for uniqueness. Components must be fully usable from both case-sensitive and case-insensitive languages. Since case-insensitive languages cannot distinguish between two names within the same context that differ only by case, components must avoid this situation..
        /// </summary>
        internal static string IdentifiersShouldDifferByMoreThanCaseDescription {
            get {
                return ResourceManager.GetString("IdentifiersShouldDifferByMoreThanCaseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Implement Serialization constructor.
        /// </summary>
        internal static string ImplementSerializationConstructor {
            get {
                return ResourceManager.GetString("ImplementSerializationConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The constructor signature accepts the same arguments as ISerializable.GetObjectData, namely, a SerializationInfo instance and a StreamingContext instance. The constructor should be protected for non-sealed classes and private for sealed classes. Failure to implement a serialization constructor will cause deserialization to fail, and throw a SerializationException..
        /// </summary>
        internal static string ImplementSerializationConstructorDescription {
            get {
                return ResourceManager.GetString("ImplementSerializationConstructorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interface names should be prefixed with &apos;I&apos;.
        /// </summary>
        internal static string InterfaceNamesShouldStartWithI {
            get {
                return ResourceManager.GetString("InterfaceNamesShouldStartWithI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mark all assemblies with ComVisible.
        /// </summary>
        internal static string MarkAllAssembliesWithComVisible {
            get {
                return ResourceManager.GetString("MarkAllAssembliesWithComVisible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The System.Runtime.InteropServices.ComVisible attribute indicates whether COM clients can use the library. Good design dictates that developers explicitly indicate COM visibility. The default value for this attribute is &apos;true&apos;. However, the best design is to mark the assembly ComVisible false, and then mark types, interfaces, and individual members as ComVisible true, as appropriate..
        /// </summary>
        internal static string MarkAllAssembliesWithComVisibleDescription {
            get {
                return ResourceManager.GetString("MarkAllAssembliesWithComVisibleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mark all non-serializable fields..
        /// </summary>
        internal static string MarkAllNonSerializableFields {
            get {
                return ResourceManager.GetString("MarkAllNonSerializableFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All fields that cannot be serialized directly should have the NonSerializedAttribute. Types that have the SerializableAttribute should not have fields of types that do not have the SerializableAttribute unless the fields are marked with the NonSerializedAttribute..
        /// </summary>
        internal static string MarkAllNonSerializableFieldsDescription {
            get {
                return ResourceManager.GetString("MarkAllNonSerializableFieldsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mark assemblies with CLSCompliantAttribute.
        /// </summary>
        internal static string MarkAssembliesWithCLSCompliantAttribute {
            get {
                return ResourceManager.GetString("MarkAssembliesWithCLSCompliantAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assemblies should explicitly state their CLS compliance using the CLSCompliant attribute. An assembly without this attribute is not CLS-compliant. Assemblies, modules, and types can be CLS-compliant even if some parts of the assembly, module, or type are not CLS-compliant. The following rules apply: 1) If the element is marked CLSCompliant, any noncompliant members must have the CLSCompliant attribute present with its argument set to false. 2) A comparable CLS-compliant alternative member must be supplied f [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MarkAssembliesWithCLSCompliantDescription {
            get {
                return ResourceManager.GetString("MarkAssembliesWithCLSCompliantDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mark Enum with FlagsAttribute.
        /// </summary>
        internal static string MarkEnumsWithFlags {
            get {
                return ResourceManager.GetString("MarkEnumsWithFlags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The enumeration appears to be made up of combinable flags. If this true, apply the Flags attribute to the enumeration..
        /// </summary>
        internal static string MarkEnumsWithFlagsDescription {
            get {
                return ResourceManager.GetString("MarkEnumsWithFlagsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The constituent members of &apos;{0}&apos; appear to represent flags that can be combined rather than discrete values. If this is correct, mark the enumeration with FlagsAttribute..
        /// </summary>
        internal static string MarkEnumsWithFlagsMessage {
            get {
                return ResourceManager.GetString("MarkEnumsWithFlagsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mark ISerializable types with SerializableAttribute..
        /// </summary>
        internal static string MarkISerializableTypesWithAttribute {
            get {
                return ResourceManager.GetString("MarkISerializableTypesWithAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The System.Runtime.Serialization.ISerializable interface allows the type to customize its serialization, while the Serializable attribute enables the runtime to recognize the type as being serializable..
        /// </summary>
        internal static string MarkISerializableTypesWithAttributeDescription {
            get {
                return ResourceManager.GetString("MarkISerializableTypesWithAttributeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move P/Invokes to native methods class.
        /// </summary>
        internal static string MovePInvokesToNativeMethodsClass {
            get {
                return ResourceManager.GetString("MovePInvokesToNativeMethodsClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to P/Invoke method &apos;{0}&apos; should not be visible.
        /// </summary>
        internal static string PInvokeMethodShouldNotBeVisible {
            get {
                return ResourceManager.GetString("PInvokeMethodShouldNotBeVisible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to P/Invokes should not be visible..
        /// </summary>
        internal static string PInvokesShouldNotBeVisible {
            get {
                return ResourceManager.GetString("PInvokesShouldNotBeVisible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove empty finalizers.
        /// </summary>
        internal static string RemoveEmptyFinalizers {
            get {
                return ResourceManager.GetString("RemoveEmptyFinalizers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finalizers should be avoided where possible, to avoid the additional performance overhead involved in tracking object lifetime..
        /// </summary>
        internal static string RemoveEmptyFinalizersDescription {
            get {
                return ResourceManager.GetString("RemoveEmptyFinalizersDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Re-throwing caught exception changes stack information..
        /// </summary>
        internal static string RethrowException {
            get {
                return ResourceManager.GetString("RethrowException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rethrow to preserve stack details..
        /// </summary>
        internal static string RethrowToPreserveStackDetails {
            get {
                return ResourceManager.GetString("RethrowToPreserveStackDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seal attribute types for improved performance. Sealing attribute types speeds up performance during reflection on custom attributes..
        /// </summary>
        internal static string SealAttributeTypesForImprovedPerf {
            get {
                return ResourceManager.GetString("SealAttributeTypesForImprovedPerf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Serializable type {0} doesn&apos;t have a serialization constructor.
        /// </summary>
        internal static string SerializableTypeDoesntHaveCtor {
            get {
                return ResourceManager.GetString("SerializableTypeDoesntHaveCtor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Declare serialization constructor for sealed type {0} as private.
        /// </summary>
        internal static string SerializationCtorAccessibilityForSealedType {
            get {
                return ResourceManager.GetString("SerializationCtorAccessibilityForSealedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Declare serialization constructor for unsealed type {0} as protected.
        /// </summary>
        internal static string SerializationCtorAccessibilityForUnSealedType {
            get {
                return ResourceManager.GetString("SerializationCtorAccessibilityForUnSealedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify marshaling for P/Invoke string arguments.
        /// </summary>
        internal static string SpecifyMarshalingForPInvokeStringArguments {
            get {
                return ResourceManager.GetString("SpecifyMarshalingForPInvokeStringArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When marshaling strings as ANSI (or as Auto on Win9x), some characters may be changed. If best-fit mapping is on, strings that appear different in Unicode will be marshaled to identical ANSI strings, which may lead to incorrect security decisions. Turning best-fit mapping off reduces this risk, as all characters without equivalents are mapped to &apos;?&apos;. Also, note that CharSet.Ansi is the default setting for all string marshaling; Unicode marshaling must be specified explicitly, either as a CharSet setting of  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpecifyMarshalingForPInvokeStringArgumentsDescription {
            get {
                return ResourceManager.GetString("SpecifyMarshalingForPInvokeStringArgumentsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is a static holder type but is neither static nor NotInheritable.
        /// </summary>
        internal static string StaticHolderTypeIsNotStatic {
            get {
                return ResourceManager.GetString("StaticHolderTypeIsNotStatic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static holder types should be Static or NotInheritable.
        /// </summary>
        internal static string StaticHolderTypesShouldBeStaticOrNotInheritable {
            get {
                return ResourceManager.GetString("StaticHolderTypesShouldBeStaticOrNotInheritable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static holder types should not have instance constructors.
        /// </summary>
        internal static string StaticHolderTypesShouldNotHaveConstructors {
            get {
                return ResourceManager.GetString("StaticHolderTypesShouldNotHaveConstructors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is a static holder type and should not contain Instance Constructors.
        /// </summary>
        internal static string StaticHolderTypesShouldNotHaveConstructorsMessage {
            get {
                return ResourceManager.GetString("StaticHolderTypesShouldNotHaveConstructorsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For non-linguistic comparisons, StringComparison.Ordinal or StringComparison.OrdinalIgnoreCase should be used instead of the linguistically-sensitive StringComparison.InvariantCulture..
        /// </summary>
        internal static string StringComparisonShouldBeOrdinalDescription {
            get {
                return ResourceManager.GetString("StringComparisonShouldBeOrdinalDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String comparison should use StringComparison.Ordinal or StringComparison.OrdinalIgnoreCase.
        /// </summary>
        internal static string StringComparisonShouldBeOrdinalOrOrdinalIgnoreCase {
            get {
                return ResourceManager.GetString("StringComparisonShouldBeOrdinalOrOrdinalIgnoreCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is abstract but has public constructors.
        /// </summary>
        internal static string TypeIsAbstractButHasPublicConstructors {
            get {
                return ResourceManager.GetString("TypeIsAbstractButHasPublicConstructors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; owns disposable fields but is not disposable.
        /// </summary>
        internal static string TypeOwnsDisposableFieldButIsNotDisposable {
            get {
                return ResourceManager.GetString("TypeOwnsDisposableFieldButIsNotDisposable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type parameter names should be prefixed with &apos;T&apos;.
        /// </summary>
        internal static string TypeParameterNamesShouldStartWithT {
            get {
                return ResourceManager.GetString("TypeParameterNamesShouldStartWithT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Types that own disposable fields should be disposable.
        /// </summary>
        internal static string TypesThatOwnDisposableFieldsShouldBeDisposable {
            get {
                return ResourceManager.GetString("TypesThatOwnDisposableFieldsShouldBeDisposable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use System.EventHandler&lt;T&gt; where T inherits System.EventArgs or use System.EventHandler.
        /// </summary>
        internal static string UseGenericEventHandlerInstances {
            get {
                return ResourceManager.GetString("UseGenericEventHandlerInstances", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use properties where appropriate..
        /// </summary>
        internal static string UsePropertiesWhereAppropriate {
            get {
                return ResourceManager.GetString("UsePropertiesWhereAppropriate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Properties should be used instead of Get/Set methods in most situations. Methods are preferable to properties in the following situations: the operation is a conversion, is expensive or has an observable side-effect; the order of execution is important; calling the member twice in succession creates different results; a member is static but returns a mutable value; or the member returns an array..
        /// </summary>
        internal static string UsePropertiesWhereAppropriateDescription {
            get {
                return ResourceManager.GetString("UsePropertiesWhereAppropriateDescription", resourceCulture);
            }
        }
    }
}
