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
    
    
    public class AIRuntimeStatusRandom : AIRunTimeBase {
        
        public int mAIArgProb;
        
        public override void Init(AI.Runtime.AIRuntimeTaskData data) {
			base.Init(data);
			if(data.vars[0].val != null)
				mAIArgProb = (System.Int32)data.vars[0].val;
        }
        
        public override AIRuntimeStatus OnTick(XEntity entity) {
			return AITreeImpleted.StatusRandomUpdate(entity, mAIArgProb);
        }
    }
}
