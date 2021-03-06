using UnityEditor.SceneTemplate;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.SceneManagement;

namespace UnityEditor.Rendering.HighDefinition
{
    class HDRPBasicScenePipeline : ISceneTemplatePipeline
    {
        void ISceneTemplatePipeline.AfterTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, Scene scene, bool isAdditive, string sceneName)
        { }

        void ISceneTemplatePipeline.BeforeTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, bool isAdditive, string sceneName)
        { }

        bool ISceneTemplatePipeline.IsValidTemplateForInstantiation(SceneTemplateAsset sceneTemplateAsset)
        {
            var hdrpAsset = HDRenderPipeline.defaultAsset;
            if (hdrpAsset == null)
                return false;
            return !hdrpAsset.currentPlatformRenderPipelineSettings.supportRayTracing;
        }
    }
}
