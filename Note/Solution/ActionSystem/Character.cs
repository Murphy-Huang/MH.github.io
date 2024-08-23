using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Solution.ActionSystem
{
    public class Character
    {
        /// <summary>
        /// ��ǰ����֡
        /// </summary>
        public Frame currentFrame;

        /// <summary>
        /// ���յĶ���
        /// </summary>
        public List<Action> actionSet;

        /// <summary>
        /// ��ײ��¼
        /// </summary>
        public List<HitRecord> hitRecords;

        /// <summary>
        /// �������
        /// ÿ��������ӵ����List����ʱ����
        /// </summary>
        public List<Command> commandList;

        /// <summary>
        /// ������ѡ�б�
        /// �������ȼ�ð�ݣ��ó����CancelData��Ӧ�Ķ�����Ӧ֡
        /// </summary>
        public List<(int, Action)> candidateActionList;
    }
}