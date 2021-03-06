// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Waf.MusicManager.Domain.Entity.#GetChanges()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member", Target = "Waf.MusicManager.Domain.Entity.#SetPropertyAndTrackChanges`1(!!0&,!!0,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Waf.MusicManager.Domain.Entity.#SetPropertyAndTrackChanges`1(!!0&,!!0,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Waf.MusicManager.Domain.PlayedItemsStack")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Waf.MusicManager.Domain.PlaylistManager.#.ctor(System.Int32,Waf.MusicManager.Domain.IRandomService)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "maxValue+1", Scope = "member", Target = "Waf.MusicManager.Domain.RandomService.#NextRandomNumber(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Waf.MusicManager.Domain.MusicFile.#GetMetadataAsync()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Waf.MusicManager.Domain.MusicFile.#.ctor(System.Func`2<System.String,System.Threading.Tasks.Task`1<Waf.MusicManager.Domain.MusicMetadata>>,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "task", Scope = "member", Target = "Waf.MusicManager.Domain.TaskHelper.#IgnoreResult(System.Threading.Tasks.Task)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "ex", Scope = "member", Target = "Waf.MusicManager.Domain.TaskHelper.#ObserveException(System.Exception)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CanPreviousItem", Scope = "member", Target = "Waf.MusicManager.Domain.PlaylistManager.#PreviousItem()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CanNextItem", Scope = "member", Target = "Waf.MusicManager.Domain.PlaylistManager.#NextItem()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Waf.MusicManager.Domain.MusicFiles.Entity.#GetChanges()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member", Target = "Waf.MusicManager.Domain.MusicFiles.Entity.#SetPropertyAndTrackChanges`1(!!0&,!!0,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Waf.MusicManager.Domain.MusicFiles.Entity.#SetPropertyAndTrackChanges`1(!!0&,!!0,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Waf.MusicManager.Domain.IReadOnlyObservableList`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Waf.MusicManager.Domain.MusicFiles.MusicFile.#.ctor(System.Func`2<System.String,System.Threading.Tasks.Task`1<Waf.MusicManager.Domain.MusicFiles.MusicMetadata>>,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Waf.MusicManager.Domain.MusicFiles.MusicFile.#GetMetadataAsync()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Waf.MusicManager.Domain.Playlists.PlaylistManager.#.ctor(System.Int32,Waf.MusicManager.Domain.Playlists.IRandomService)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CanPreviousItem", Scope = "member", Target = "Waf.MusicManager.Domain.Playlists.PlaylistManager.#PreviousItem()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CanNextItem", Scope = "member", Target = "Waf.MusicManager.Domain.Playlists.PlaylistManager.#NextItem()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Waf.MusicManager.Domain.ReadOnlyObservableList`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Waf.MusicManager.Domain.SynchronizingList`2")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Waf.MusicManager.Domain.Logger.#GetMemberName(System.String)")]
