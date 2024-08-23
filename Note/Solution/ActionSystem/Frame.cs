using UnityEngine;

namespace Solution.ActionSystem
{
    public class Frame
    {
        /// <summary>
        /// �����ؼ�֡
        /// </summary>
        public float animationKeyframe;

        /// <summary>
        /// ѭ��֡��
        /// </summary>
        public int loopFrame;

        /// <summary>
        /// Cancel��Ϣ
        /// ��ɫ������֡��ʱ��������Щ������Cancel
        /// </summary>
        public List<CancelTag> cancelInfo;

        /// <summary>
        /// ������ײ��(Rect[]\Box[])
        /// 2D��Ϸ��ͨ����Rect������aabb����������ܣ���3D��Ϸ����Box
        /// </summary>
        public BoxCollider[] physicalBoxes;

        /// <summary>
        /// ������
        /// </summary>
        public AttackHitBox[] attackBoxes;

        /// <summary>
        /// �ܻ���
        /// </summary>
        public HurtHitBox[] hurtBoxes;

        /// <summary>
        /// ��һ֡
        /// </summary>
        public Frame nextFrame;
    }
}