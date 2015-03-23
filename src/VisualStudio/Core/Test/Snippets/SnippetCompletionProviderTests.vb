' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.ComponentModel.Composition.Hosting
Imports System.Composition
Imports System.Threading.Tasks
Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Host.Mef
Imports Microsoft.CodeAnalysis.Snippets
Imports Roslyn.Test.Utilities
Imports Roslyn.Utilities

Namespace Microsoft.VisualStudio.LanguageServices.UnitTests.Snippets
    Public Class SnippetCompletionProviderTests
        <Fact, Trait(Traits.Feature, Traits.Features.Snippets)>
        Public Sub SnippetCompletion()
            Dim markup = "a?$$"
            Dim testState = SnippetTestState.CreateTestState(markup, LanguageNames.VisualBasic, extraParts:={GetType(MockSnippetInfoService)})
            Using testState
                testState.SendTabToCompletion()

                Assert.Equal(testState.GetDocumentText(), "a")

                testState.WaitForAsynchronousOperations()
                Assert.Equal(testState.CurrentCompletionPresenterSession.SelectedItem.DisplayText, "Shortcut")
                Assert.Equal(testState.CurrentCompletionPresenterSession.SelectedItem.GetDescriptionAsync().Result.ToDisplayString(), "Description")

                testState.SendTabToCompletion()

                Assert.True(testState.SnippetExpansionClient.TryInsertExpansionCalled)
            End Using
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.Snippets)>
        Public Sub TracksChangeSpanCorrectly()
            Dim markup = "a?$$"
            Dim testState = SnippetTestState.CreateTestState(markup, LanguageNames.VisualBasic, extraParts:={GetType(MockSnippetInfoService)})
            Using testState
                testState.SendTabToCompletion()
                testState.WaitForAsynchronousOperations()
                Assert.Equal(testState.CurrentCompletionPresenterSession.SelectedItem.DisplayText, "Shortcut")

                testState.SendBackspace()
                testState.WaitForAsynchronousOperations()
                Assert.Equal(testState.CurrentCompletionPresenterSession.SelectedItem.DisplayText, "Shortcut")

                testState.SendTabToCompletion()

                Assert.True(testState.SnippetExpansionClient.TryInsertExpansionCalled)
                Assert.Equal(testState.GetDocumentText(), "Shortcut")
            End Using
        End Sub

        <Fact, Trait(Traits.Feature, Traits.Features.Snippets)>
        Public Sub SnippetListOnlyIfTextBeforeQuestionMark()
            Dim markup = <File>
Class C
    ?$$
End Class</File>.Value

            Dim testState = SnippetTestState.CreateTestState(markup, LanguageNames.VisualBasic, extraParts:={GetType(MockSnippetInfoService)})
            Using testState
                testState.SendTabToCompletion()
                testState.WaitForAsynchronousOperations()
                Assert.Null(testState.CurrentCompletionPresenterSession)
            End Using
        End Sub
    End Class

    <ExportLanguageService(GetType(ISnippetInfoService), LanguageNames.VisualBasic), [Shared]>
    Friend Class MockSnippetInfoService
        Implements ISnippetInfoService

        Public Function GetSnippetsAsync_NonBlocking() As IEnumerable(Of SnippetInfo) Implements ISnippetInfoService.GetSnippetsIfAvailable
            Return SpecializedCollections.SingletonEnumerable(New SnippetInfo("Shortcut", "Title", "Description", "Path"))
        End Function

        Public Function ShouldFormatSnippet(snippetInfo As SnippetInfo) As Boolean Implements ISnippetInfoService.ShouldFormatSnippet
            Return False
        End Function

        Public Function SnippetShortcutExists_NonBlocking(shortcut As String) As Boolean Implements ISnippetInfoService.SnippetShortcutExists_NonBlocking
            Return shortcut = "Shortcut"
        End Function
    End Class
End Namespace
