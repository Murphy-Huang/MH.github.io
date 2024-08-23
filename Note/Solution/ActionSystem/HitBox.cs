using UnityEngine;

namespace Solution
{
    public class HitBox
    {
        /// <summary>
        /// ��ײ���壨Rect\Box��
        /// �����������ڽ�ɫ�����ƫ����
        /// </summary>
        public BoxCollider[] collisionBoxes;

        /// <summary>
        /// �������仯��Ϣ
        /// ��������������ȼ����ڶ��ֿ��ʱ����ô���Լ�����θı䶯������ȡ���������Ϣ��
        /// </summary>
        public ActionChangeInfo selfActionChangeInfo;

        /// <summary>
        /// ���ֶ����仯��Ϣ
        /// ��������������ȼ����ڶ��ֿ��ʱ����ô���ֻ���θı䶯������ȡ���������Ϣ��
        /// </summary>
        public ActionChangeInfo counterpartActionChangeInfo;

        /// <summary>
        /// ���ȼ�
        /// ��һ����ɫ�Ĺ����������������ܻ������Ϣ�б�ð�ݣ��ȸ��ݹ���������ȼ�ð�ݣ����������ȼ���ߵ��Ǹ�����ͬʱ�������˺ܶ��ܻ��򣬴�ʱð�ݳ��ܻ������ȼ���ߵģ����������ײ�ġ���Ч��ײ��Ϣ��˫���Ŀ򣩡�
        /// ���ȼ��Աȣ��ó��������������ȼ�>������>=���ܻ�������ȼ�������ù������ġ������仯��Ϣ��������Ͷ���������������������ܻ�����
        /// </summary>
        public int prioritization;

        /// <summary>
        /// �ԳƱ�־����ײ���־��ͬʱ�������Ч
        /// </summary>
        public string[] counterpartMark;
    }
}