using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动进度 message
 */
public class ResActivityProgressMessage : Message 
{
	//活动进度详情
	List<ActivityProgress> _progressInfo = new List<ActivityProgress>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动进度详情
		SerializeUtils.WriteShort(stream, (short)_progressInfo.Count);

		foreach (var element in _progressInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动进度详情
		int _progressInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _progressInfo_length; ++i) 
		{
			_progressInfo.Add(SerializeUtils.ReadBean<ActivityProgress>(stream));
		}
	}
	
	/**
	 * get 活动进度详情
	 * @return 
	 */
	public List<ActivityProgress> GetProgressInfo()
	{
		return _progressInfo;
	}
	
	/**
	 * set 活动进度详情
	 */
	public void SetProgressInfo(List<ActivityProgress> progressInfo)
	{
		_progressInfo = progressInfo;
	}
	
	
	public override int GetId() 
	{
		return 311109;
	}
}