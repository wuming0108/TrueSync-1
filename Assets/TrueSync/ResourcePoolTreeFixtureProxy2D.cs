using System;
using TrueSync.Physics2D;

namespace TrueSync
{
	internal class ResourcePoolTreeFixtureProxy2D : ResourcePool<TreeNode<FixtureProxy>>
	{
		protected override TreeNode<FixtureProxy> NewInstance()
		{
			return new TreeNode<FixtureProxy>();
		}
	}
}
