namespace Solution.ActionSystem
{
    public class CancelTag
    {
        /// <summary>
        /// ��CancelData��tag��Ӧ��ֻ����CancelData��tag�������tag�Ż����Cancel��ϵ
        /// </summary>
        public string tag;

        /// <summary>
        /// ���ȼ�����
        /// ������������ڴ�֡����Cancel����ô�Ǹ����������ȼ��ᱻ�������ֵ��������
        /// </summary>
        public int prioritizationModifier;

        /// <summary>
        /// ���ڼ���
        /// һЩcancel���������ʱ��������ض��������
        /// ������������ײ��ActionChangeInfo�У�����
        /// </summary>
        public bool active = true;
    }
}