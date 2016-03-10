﻿using UnityEngine;

namespace UrMotion
{
	public abstract class MotionVec1<T> : MotionBehaviour<float> where T : MotionBehaviour<float>
	{
		public static MotionBehaviour<float> Add(GameObject g)
		{
			return Get<T>(g);
		}

		override protected float Add(float a, float b)
		{
			return a + b;
		}
	}

	public abstract class MotionVec1T<T> : MotionVec1<T> where T : MotionBehaviour<float>
	{
		public abstract Vector3 vector { get; set; }

		Transform t;

		protected Transform GetTransform()
		{
			return t ?? (t = transform);
		}
	}

	public abstract class MotionVec1P<T> : MotionVec1T<T> where T : MotionBehaviour<float>
	{
		override public Vector3 vector {
			get {
				return GetTransform().localPosition;
			}
			set {
				GetTransform().localPosition = value;
			}
		}
	}

	public abstract class MotionVec1WP<T> : MotionVec1T<T> where T : MotionBehaviour<float>
	{
		override public Vector3 vector {
			get {
				return GetTransform().position;
			}
			set {
				GetTransform().position = value;
			}
		}
	}

	public abstract class MotionVec1R<T> : MotionVec1T<T> where T : MotionBehaviour<float>
	{
		override public Vector3 vector {
			get {
				return GetTransform().localEulerAngles;
			}
			set {
				GetTransform().localEulerAngles = value;
			}
		}
	}

	public abstract class MotionVec1WR<T> : MotionVec1T<T> where T : MotionBehaviour<float>
	{
		override public Vector3 vector {
			get {
				return GetTransform().eulerAngles;
			}
			set {
				GetTransform().eulerAngles = value;
			}
		}
	}

	public abstract class MotionVec1S<T> : MotionVec1T<T> where T : MotionBehaviour<float>
	{
		override public Vector3 vector {
			get {
				return GetTransform().localScale;
			}
			set {
				GetTransform().localScale = value;
			}
		}
	}
}