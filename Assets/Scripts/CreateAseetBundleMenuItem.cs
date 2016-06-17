#if UNITY_EDITOR
using UnityEditor;

public class CreateAssetBundles{

	[MenuItem ("Assets/Build Asset Bundles/Build AssetBundles for Editor")]
	
	static void BuildAllAssetBundles (){
		BuildPipeline.BuildAssetBundles("Assets/Asset Bundles/Editor");
	}

	[MenuItem ("Assets/Build Asset Bundles/Build AssetBundles for Android")]

	static void BuildAndroidAssetBundles (){
		BuildPipeline.BuildAssetBundles("Assets/Asset Bundles/Android", BuildAssetBundleOptions.None, BuildTarget.Android);
	}

	[MenuItem ("Assets/Build Asset Bundles/Build AssetBundles for iOS")]
	
	static void BuildIOSAssetBundles (){
		BuildPipeline.BuildAssetBundles("Assets/Asset Bundles/iOS", BuildAssetBundleOptions.None, BuildTarget.iOS);
	}
}
#endif