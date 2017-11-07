// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace AI.Runtime {
    using UnityEngine;
    
    
    public class AIRuntimeRotateToTarget : AIRunTimeBase {
        
        public GameObject mAIArgTarget;
        
        public float floatmAIArgAngle;
        
        public override void Init(AI.Runtime.AIRuntimeTaskData data) {
			base.Init(data);
			if(data.vars[1].val != null)
				floatmAIArgAngle = (System.Single)data.vars[1].val;
        }
        
        public override AIRuntimeStatus OnTick(XEntity entity) {
			var inmAIArgTarget = _tree.GetVariable("target"); 
			if (inmAIArgTarget != null) mAIArgTarget = (GameObject)inmAIArgTarget;
			return AITreeImpleted.RotateToTargetUpdate(entity, mAIArgTarget, floatmAIArgAngle);
        }
    }
}
