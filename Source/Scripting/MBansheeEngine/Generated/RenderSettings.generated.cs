using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Rendering
	 *  @{
	 */

	/// <summary>Settings that control rendering for a specific camera (view).</summary>
	public partial class RenderSettings : ScriptObject
	{
		private RenderSettings(bool __dummy0) { }

		public RenderSettings()
		{
			Internal_RenderSettings(this);
		}

		/// <summary>
		/// Determines should automatic exposure be applied to the HDR image. When turned on the average scene brightness will be 
		/// calculated and used to automatically expose the image to the optimal range. Use the parameters provided by 
		/// autoExposure to customize the automatic exposure effect. You may also use exposureScale to manually adjust the 
		/// automatic exposure. When automatic exposure is turned off you can use exposureScale to manually set the exposure.
		/// </summary>
		public bool EnableAutoExposure
		{
			get { return Internal_getenableAutoExposure(mCachedPtr); }
			set { Internal_setenableAutoExposure(mCachedPtr, value); }
		}

		/// <summary>Parameters used for customizing automatic scene exposure.</summary>
		public AutoExposureSettings AutoExposure
		{
			get { return Internal_getautoExposure(mCachedPtr); }
			set { Internal_setautoExposure(mCachedPtr, value); }
		}

		/// <summary>
		/// Determines should the image be tonemapped. Tonemapping converts an HDR image into LDR image by applying a filmic 
		/// curve to the image, simulating the effect of film cameras. Filmic curve improves image quality by tapering off lows 
		/// and highs, preventing under- and over-exposure. This is useful if an image contains both very dark and very bright 
		/// areas, in which case the global exposure parameter would leave some areas either over- or under-exposed. Use 
		/// #tonemapping to customize how tonemapping performed.
		///
		/// If this is disabled, then color grading and white balancing will not be enabled either. Only relevant for HDR images.
		/// </summary>
		public bool EnableTonemapping
		{
			get { return Internal_getenableTonemapping(mCachedPtr); }
			set { Internal_setenableTonemapping(mCachedPtr, value); }
		}

		/// <summary>Parameters used for customizing tonemapping.</summary>
		public TonemappingSettings Tonemapping
		{
			get { return Internal_gettonemapping(mCachedPtr); }
			set { Internal_settonemapping(mCachedPtr, value); }
		}

		/// <summary>
		/// Parameters used for customizing white balancing. White balancing converts a scene illuminated by a light of the 
		/// specified temperature into a scene illuminated by a standard D65 illuminant (average midday light) in order to 
		/// simulate the effects of chromatic adaptation of the human visual system.
		/// </summary>
		public WhiteBalanceSettings WhiteBalance
		{
			get { return Internal_getwhiteBalance(mCachedPtr); }
			set { Internal_setwhiteBalance(mCachedPtr, value); }
		}

		/// <summary>Parameters used for customizing color grading.</summary>
		public ColorGradingSettings ColorGrading
		{
			get { return Internal_getcolorGrading(mCachedPtr); }
			set { Internal_setcolorGrading(mCachedPtr, value); }
		}

		/// <summary>Parameters used for customizing the depth of field effect.</summary>
		public DepthOfFieldSettings DepthOfField
		{
			get { return Internal_getdepthOfField(mCachedPtr); }
			set { Internal_setdepthOfField(mCachedPtr, value); }
		}

		/// <summary>Parameters used for customizing screen space ambient occlusion.</summary>
		public AmbientOcclusionSettings AmbientOcclusion
		{
			get { return Internal_getambientOcclusion(mCachedPtr); }
			set { Internal_setambientOcclusion(mCachedPtr, value); }
		}

		/// <summary>Parameters used for customizing screen space reflections.</summary>
		public ScreenSpaceReflectionsSettings ScreenSpaceReflections
		{
			get { return Internal_getscreenSpaceReflections(mCachedPtr); }
			set { Internal_setscreenSpaceReflections(mCachedPtr, value); }
		}

		/// <summary>Enables the fast approximate anti-aliasing effect.</summary>
		public bool EnableFXAA
		{
			get { return Internal_getenableFXAA(mCachedPtr); }
			set { Internal_setenableFXAA(mCachedPtr, value); }
		}

		/// <summary>
		/// Log2 value to scale the eye adaptation by (for example 2^0 = 1). Smaller values yield darker image, while larger 
		/// yield brighter image. Allows you to customize exposure manually, applied on top of eye adaptation exposure (if 
		/// enabled). In range [-8, 8].
		/// </summary>
		public float ExposureScale
		{
			get { return Internal_getexposureScale(mCachedPtr); }
			set { Internal_setexposureScale(mCachedPtr, value); }
		}

		/// <summary>
		/// Gamma value to adjust the image for. Larger values result in a brighter image. When tonemapping is turned on the best 
		/// gamma curve for the output device is chosen automatically and this value can by used to merely tweak that curve. If 
		/// tonemapping is turned off this is the exact value of the gamma curve that will be applied.
		/// </summary>
		public float Gamma
		{
			get { return Internal_getgamma(mCachedPtr); }
			set { Internal_setgamma(mCachedPtr, value); }
		}

		/// <summary>
		/// High dynamic range allows light intensity to be more correctly recorded when rendering by allowing for a larger range 
		/// of values. The stored light is then converted into visible color range using exposure and a tone mapping  operator.
		/// </summary>
		public bool EnableHDR
		{
			get { return Internal_getenableHDR(mCachedPtr); }
			set { Internal_setenableHDR(mCachedPtr, value); }
		}

		/// <summary>
		/// Determines if scene objects will be lit by lights. If disabled everything will be rendered using their albedo texture 
		/// with no lighting applied.
		/// </summary>
		public bool EnableLighting
		{
			get { return Internal_getenableLighting(mCachedPtr); }
			set { Internal_setenableLighting(mCachedPtr, value); }
		}

		/// <summary>Determines if shadows cast by lights should be rendered. Only relevant if lighting is turned on.</summary>
		public bool EnableShadows
		{
			get { return Internal_getenableShadows(mCachedPtr); }
			set { Internal_setenableShadows(mCachedPtr, value); }
		}

		/// <summary>Parameters used for customizing shadow rendering.</summary>
		public ShadowSettings ShadowSettings
		{
			get { return Internal_getshadowSettings(mCachedPtr); }
			set { Internal_setshadowSettings(mCachedPtr, value); }
		}

		/// <summary>Determines if indirect lighting (e.g. from light probes or the sky) is rendered.</summary>
		public bool EnableIndirectLighting
		{
			get { return Internal_getenableIndirectLighting(mCachedPtr); }
			set { Internal_setenableIndirectLighting(mCachedPtr, value); }
		}

		/// <summary>
		/// Signals the renderer to only render overlays (like GUI), and not scene objects. Such rendering doesn't require depth 
		/// buffer or multi-sampled render targets and will not render any scene objects. This can improve performance and memory 
		/// usage for overlay-only views.
		/// </summary>
		public bool OverlayOnly
		{
			get { return Internal_getoverlayOnly(mCachedPtr); }
			set { Internal_setoverlayOnly(mCachedPtr, value); }
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RenderSettings(RenderSettings managedInstance);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_getenableAutoExposure(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setenableAutoExposure(IntPtr thisPtr, bool value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AutoExposureSettings Internal_getautoExposure(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setautoExposure(IntPtr thisPtr, AutoExposureSettings value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_getenableTonemapping(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setenableTonemapping(IntPtr thisPtr, bool value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TonemappingSettings Internal_gettonemapping(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_settonemapping(IntPtr thisPtr, TonemappingSettings value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern WhiteBalanceSettings Internal_getwhiteBalance(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setwhiteBalance(IntPtr thisPtr, WhiteBalanceSettings value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ColorGradingSettings Internal_getcolorGrading(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setcolorGrading(IntPtr thisPtr, ColorGradingSettings value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern DepthOfFieldSettings Internal_getdepthOfField(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setdepthOfField(IntPtr thisPtr, DepthOfFieldSettings value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AmbientOcclusionSettings Internal_getambientOcclusion(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setambientOcclusion(IntPtr thisPtr, AmbientOcclusionSettings value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ScreenSpaceReflectionsSettings Internal_getscreenSpaceReflections(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setscreenSpaceReflections(IntPtr thisPtr, ScreenSpaceReflectionsSettings value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_getenableFXAA(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setenableFXAA(IntPtr thisPtr, bool value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_getexposureScale(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setexposureScale(IntPtr thisPtr, float value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_getgamma(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setgamma(IntPtr thisPtr, float value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_getenableHDR(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setenableHDR(IntPtr thisPtr, bool value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_getenableLighting(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setenableLighting(IntPtr thisPtr, bool value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_getenableShadows(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setenableShadows(IntPtr thisPtr, bool value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ShadowSettings Internal_getshadowSettings(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setshadowSettings(IntPtr thisPtr, ShadowSettings value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_getenableIndirectLighting(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setenableIndirectLighting(IntPtr thisPtr, bool value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_getoverlayOnly(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setoverlayOnly(IntPtr thisPtr, bool value);
	}

	/** @} */
}
