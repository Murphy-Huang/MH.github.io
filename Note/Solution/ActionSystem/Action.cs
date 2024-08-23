namespace Solution.ActionSystem
{
    public class Action
    {
        /// <summary>
        /// ������
        /// ��ͬ�Ķ���������ȫ��ȣ���Ҫ���������
        /// </summary>
        public string actionName { get; private set; }

        /// <summary>
        /// ����֡
        /// </summary>
        public List<Frame> actionFrame;

        /// <summary>
        /// �νӵ��¸�����
        /// </summary>
        public Action nextAction;

        /// <summary>
        /// ������Ϣ
        /// string��������
        /// </summary>
        public string animationInfo;

        /// <summary>
        /// ����ָ��
        /// ���Խ����������
        /// </summary>
        public Command[] command;

        /// <summary>
        /// ����Cancel��Ķ�������Ϣ
        /// </summary>
        public List<CancelData> CancelTags;

        /// <summary>
        /// �������ȼ�
        /// </summary>
        public int prioritization;

        /// <summary>
        /// �����Ϣ
        /// </summary>
        public HitInfo hitInfo;


        /// <summary>
        /// ������ֵ����������
        /// </summary>
        public int multiplier;
    }
}