using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步援护技能 message
 */
public class ResAssistSkillInfoMessage : Message 
{
	//技能信息
	List<AssistSkillInfo> _assistSkillInfo = new List<AssistSkillInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//技能信息
		SerializeUtils.WriteShort(stream, (short)_assistSkillInfo.Count);

		foreach (var element in _assistSkillInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//技能信息
		int _assistSkillInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _assistSkillInfo_length; ++i) 
		{
			_assistSkillInfo.Add(SerializeUtils.ReadBean<AssistSkillInfo>(stream));
		}
	}
	
	/**
	 * get 技能信息
	 * @return 
	 */
	public List<AssistSkillInfo> GetAssistSkillInfo()
	{
		return _assistSkillInfo;
	}
	
	/**
	 * set 技能信息
	 */
	public void SetAssistSkillInfo(List<AssistSkillInfo> assistSkillInfo)
	{
		_assistSkillInfo = assistSkillInfo;
	}
	
	
	public override int GetId() 
	{
		return 208300;
	}
}