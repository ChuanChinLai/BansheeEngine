using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Rendering
	 *  @{
	 */

	/// <summary>
	/// Specifies a location at which a pre-computed texture containing scene radiance will be generated. This texture will 
	/// then be used by the renderer to provide specular reflections.
	/// </summary>
	public partial class ReflectionProbe : Component
	{
		private ReflectionProbe(bool __dummy0) { }
		protected ReflectionProbe() { }

		/// <summary>Changes the type of the probe.</summary>
		[ShowInInspector]
		public ReflectionProbeType Type
		{
			get { return Internal_getType(mCachedPtr); }
			set { Internal_setType(mCachedPtr, value); }
		}

		/// <summary>Sets the radius of a sphere reflection probe.</summary>
		[ShowInInspector]
		public float Radius
		{
			get { return Internal_getRadius(mCachedPtr); }
			set { Internal_setRadius(mCachedPtr, value); }
		}

		/// <summary>Sets the extents of a box reflection probe. Determines range of influence.</summary>
		[ShowInInspector]
		public Vector3 Extents
		{
			get
			{
				Vector3 temp;
				Internal_getExtents(mCachedPtr, out temp);
				return temp;
			}
			set { Internal_setExtents(mCachedPtr, ref value); }
		}

		/// <summary>
		/// Allows you assign a custom texture to use as a reflection map. This will disable automatic generation of reflections. 
		/// To re-enable auto-generation call this with a null parameter.
		/// </summary>
		[ShowInInspector]
		public Texture CustomTexture
		{
			get { return Internal_getCustomTexture(mCachedPtr); }
			set { Internal_setCustomTexture(mCachedPtr, value); }
		}

		/// <summary>
		/// Captures the scene at the current location and generates a filtered reflection cubemap. No action is taken if a 
		/// custom texture is set.
		/// </summary>
		public void Capture()
		{
			Internal_capture(mCachedPtr);
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ReflectionProbeType Internal_getType(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setType(IntPtr thisPtr, ReflectionProbeType type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_getRadius(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setRadius(IntPtr thisPtr, float radius);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_getExtents(IntPtr thisPtr, out Vector3 __output);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setExtents(IntPtr thisPtr, ref Vector3 extents);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Texture Internal_getCustomTexture(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setCustomTexture(IntPtr thisPtr, Texture texture);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_capture(IntPtr thisPtr);
	}

	/** @} */
}
