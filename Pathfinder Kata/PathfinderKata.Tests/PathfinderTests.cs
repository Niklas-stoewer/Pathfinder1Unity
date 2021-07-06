using CodeWars;
using NUnit.Framework;
using UnityEngine;

namespace PathfinderKata.Tests
{
	public sealed class PathfinderTests
	{
		[Test]
		public void CheckStartTargetAndPathLength()
		{
			// ReSharper disable once Unity.IncorrectMonoBehaviourInstantiation
			var path = new PathFinderCanYouReachTheExit(Pathfinder.Map).GetPath();
			Assert.That(path![0], Is.EqualTo((8, 1)));
			Assert.That(path[^1], Is.EqualTo((2, 3)));
			Assert.That(path, Has.Count!.GreaterThanOrEqualTo(3).And.Count.LessThan(20));
		}
	}
}