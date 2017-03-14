﻿using UnityEngine;
using System.Collections;
using FSM;

namespace RPGSurvival {
	public class FSMWaitCommandState : FSMControlState
	{
		public FSMWaitCommandState(IContext context) : base (context)
		{

		}

		public override void StartState()
		{
			base.StartState ();
			m_Controller.SetIsObstacle (false);
			if (m_Controller.GetNest () != null) {
				m_Controller.GetNest ().FreeLine (m_Controller);
			}
		}

		public override void UpdateState(float dt)
		{
			base.UpdateState (dt);
		}

		public override void ExitState()
		{
			base.ExitState ();
		}
	}
}
