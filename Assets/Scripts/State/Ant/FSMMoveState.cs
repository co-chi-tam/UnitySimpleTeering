﻿using UnityEngine;
using System.Collections;
using FSM;

namespace RPGSurvival {
	public class FSMMoveState : FSMControlState
	{

		public FSMMoveState(IContext context) : base (context)
		{
			
		}

		public override void StartState()
		{
			base.StartState ();
			m_Controller.SetIsObstacle (true);
			if (m_Controller.GetNest () != null) {
				m_Controller.GetNest ().AddLineWorker (m_Controller);
			}
		}

		public override void UpdateState(float dt)
		{
			base.UpdateState (dt);
			m_Controller.MoveToTarget (dt);
		}

		public override void ExitState()
		{
			base.ExitState ();
		}
	}
}
