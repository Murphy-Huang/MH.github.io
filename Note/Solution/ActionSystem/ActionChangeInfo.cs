namespace Solution.ActionSystem
{
    /// <summary>
    /// �仯����
    /// </summary>
    public enum ChangeType
    {

    }

    public class ActionChangeInfo
    {
        /// <summary>
        /// �������ڵĶ��������߱仯��ĳ��ָ������
        /// </summary>
        public ChangeType changeType;

        /// <summary>
        /// �仯Ϊ����
        /// ��������Ǳ仯Ϊָ�����ƵĶ�������ô�����ɫ�������ַ�������Ķ��������ܻ��кü���ͬ���Ķ�����ÿһ����Ҫ����һ���жϣ����ͻ��ж��Ƿ�����Cancel���������ͻᱻ�����ѡ�б�
        /// </summary>
        public string changeToAction;

        /// <summary>
        /// ��ʼ֡
        /// �仯Ϊ�Ǹ�������ʼ֡�ǵڼ�֡
        /// </summary>
        public Frame startFrame;

        /// <summary>
        /// ��ʱ������CancelTag��Ϣ��ʵ�����У�
        /// �仯��������ʱ��������֡��int����CancelTag
        /// </summary>
        public List<(CancelTag, int)> tempCancelTag;
    }
}