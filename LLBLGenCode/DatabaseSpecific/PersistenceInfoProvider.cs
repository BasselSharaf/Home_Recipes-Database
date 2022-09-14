﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace HomeRecipes.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	internal static class PersistenceInfoProviderSingleton
	{
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton() {	}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance() { return _providerInstance; }
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitCategoryEntityMappings();
			InitRecipeEntityMappings();
			InitUserEntityMappings();
		}

		/// <summary>Inits CategoryEntity's mappings</summary>
		private void InitCategoryEntityMappings()
		{
			this.AddElementMapping("CategoryEntity", @"HomeRecipes", @"dbo", "Categories", 1, 0);
			this.AddElementFieldMapping("CategoryEntity", "Name", "Name", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 0);
		}

		/// <summary>Inits RecipeEntity's mappings</summary>
		private void InitRecipeEntityMappings()
		{
			this.AddElementMapping("RecipeEntity", @"HomeRecipes", @"dbo", "Recipe", 3, 0);
			this.AddElementFieldMapping("RecipeEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0);
			this.AddElementFieldMapping("RecipeEntity", "Instructions", "Instructions", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("RecipeEntity", "Title", "Title", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping("UserEntity", @"HomeRecipes", @"dbo", "Users", 3, 0);
			this.AddElementFieldMapping("UserEntity", "Password", "Password", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("UserEntity", "RefreshToken", "RefreshToken", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("UserEntity", "Username", "Username", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 2);
		}

	}
}