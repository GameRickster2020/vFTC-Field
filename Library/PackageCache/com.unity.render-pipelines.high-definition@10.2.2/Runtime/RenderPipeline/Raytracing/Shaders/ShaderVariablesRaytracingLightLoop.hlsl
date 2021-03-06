#ifndef UNITY_SHADER_VARIABLES_RAY_TRACING_LIGHT_LOOP_INCLUDED
#define UNITY_SHADER_VARIABLES_RAY_TRACING_LIGHT_LOOP_INCLUDED

#include "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracingLightLoop.cs.hlsl"

GLOBAL_RESOURCE(StructuredBuffer<uint>, _RaytracingLightCluster, RAY_TRACING_LIGHT_CLUSTER_REGISTER);
GLOBAL_RESOURCE(StructuredBuffer<LightData>, _LightDatasRT, RAY_TRACING_LIGHT_DATA_REGISTER);
GLOBAL_RESOURCE(StructuredBuffer<EnvLightData>, _EnvLightDatasRT, RAY_TRACING_ENV_LIGHT_DATA_REGISTER);

#endif // UNITY_SHADER_VARIABLES_RAY_TRACING_LIGHT_LOOP_INCLUDED
