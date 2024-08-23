namespace Solution.ActionSystem
{
    public class CancelData
    {
        /// <summary>
        /// ��CancelTag��tag��Ӧ��һ����������Cancel�Ķ���֡�����кܶ�
        /// </summary>
        public string[] tag;

        /// <summary>
        /// ���ȼ�����
        /// ��������������CancelDataȥCancel��Ķ�����ʱ�򣬶��������ȼ����˼���CancelTag�����ȼ�,��Ҫ����CancelData�����ȼ�
        /// </summary>
        public int prioritizationModifier;

        /// <summary>
        /// ָ��仯
        /// һЩ������ĳЩ������Cancel���������������и�����߸��ٵ�ָ�
        /// �Ա���������ʹ��������Ҫ����Ҹ���ȷ�Ĳ�������ʹ����
        /// </summary>
        public Command[] changeCommand;

        /// <summary>
        /// ��ʼ֡
        /// ���������Cancel��֮ǰ�Ķ���֮���Ǵӵڼ�֡��ʼ��
        /// </summary>
        public int startFrame;

        /// <summary>
        /// ��ʱ������CancelTag��Ϣ
        /// </summary>
        public List<(CancelTag, int)> tempCancelTag;
    }
}