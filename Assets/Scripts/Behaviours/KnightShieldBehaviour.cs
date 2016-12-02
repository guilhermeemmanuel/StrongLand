using UnityEngine;
using System.Collections;

public class KnightShieldBehaviour : StateMachineBehaviour {

    GameObject shield;

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        Transform transform = animator.GetComponent<Transform>();
       
        float direction = Mathf.Sign(Mathf.Floor(Mathf.Sin(transform.rotation.y)));

        //Debug.Log(Mathf.Cos(transform.rotation.y));


        Vector3 positionToInstantiate = new Vector3(transform.position.x + 0.3f * direction, transform.position.y , transform.position.z);
        shield = Instantiate(animator.GetComponent<PlayerController>().shieldObject, positionToInstantiate, transform.rotation) as GameObject;
    }

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        Destroy(shield);
	}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
